using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminTixketID.Properties;
using MySql.Data.MySqlClient;
using System.IO;

namespace AdminTixketID
{
    public partial class Form1 : Form
    {
        public static List<ItemFilm> itemFilmList = new List<ItemFilm>();
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void tambahFilm_Click(object sender, EventArgs e)
        {
            if (tambahFilmButton.Text.Contains("Tambah"))
            {
                tambahFilmButton.Text = "Tampil Film";
                connection.Close();
                tambahFilmControl1.BringToFront(EditOrInsert.Insert);
            }
            else
            {
                tambahFilmButton.Text = "Tambah Film";
                daftarFilmControl1.BringToFront();
                GenerateItemList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daftarFilmControl1.BringToFront();
        }
        public void CheckConnectionState()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            if (connection.State != ConnectionState.Open)
            connection.Open();
        }
        public void GenerateItemList()
        {
            CheckConnectionState();
            itemFilmList.Clear();
            daftarFilmControl1.FilmLayout.Controls.Clear();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT id_film,judul,sinopsis,gambar FROM daftar_film";
            var da = new MySqlDataAdapter(command);
            var table = new DataTable();
            da.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ItemFilm item = new ItemFilm();
                //if (!reader.Read()) continue;
                item.Id_film = table.Rows[i][0].ToString();
                item.Judul = table.Rows[i][1].ToString();
                item.Sinopsis = table.Rows[i][2].ToString();
                MemoryStream ms = new MemoryStream((byte[])table.Rows[i][3]);
                item.Gambar = Image.FromStream(ms);
                item.ambilData = MengambilTampilanData;
                item.hapusData = MenghapusData;
                itemFilmList.Add(item);
            }
            daftarFilmControl1.FilmLayout.Controls.AddRange(itemFilmList.ToArray());
        }
        private void TambahFilmControlFunction()
        {
            tambahFilmControl1.insertAction = InsertDataToDatabase;
            tambahFilmControl1.updateAction = UpdateDataToDatabase;
            tambahFilmControl1.browseImage = Browse;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=bioskop_tixket_id;Uid=root;Pwd=;");
            try
            {
                CheckConnectionState();
                Console.WriteLine("Connection Berhasil dibuka!!!");
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            GenerateItemList();
            TambahFilmControlFunction();
        }
        private void Browse()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                tambahFilmControl1.Gambar = Image.FromFile(op.FileName);
            }
        }
        private void InsertDataToDatabase()
        {
            CheckConnectionState();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO daftar_film (id_film,judul,sinopsis,gambar,nama_bioskop,lokasi,harga,jadwal_tayang,durasi_film_menit) values (@id_film,@judul,@sinopsis,@gambar,@nama_bioskop,@lokasi,@harga,@jadwal_tayang,@durasi_film_menit)";
            command.Parameters.AddWithValue("@id_film", tambahFilmControl1.IdFilm);
            command.Parameters.AddWithValue("@judul", tambahFilmControl1.Judul);
            command.Parameters.AddWithValue("@sinopsis", tambahFilmControl1.Sinopsis);

            MemoryStream ms = new MemoryStream();
            tambahFilmControl1.Gambar.Save(ms, tambahFilmControl1.Gambar.RawFormat);
            byte[] img = ms.ToArray();
            command.Parameters.AddWithValue("@gambar", img);
            command.Parameters.AddWithValue("@nama_bioskop", tambahFilmControl1.NamaBioskop);
            command.Parameters.AddWithValue("@lokasi", tambahFilmControl1.LokasiBioskop);
            command.Parameters.AddWithValue("@harga", tambahFilmControl1.Harga);
            command.Parameters.AddWithValue("@jadwal_tayang", tambahFilmControl1.JadwalTimePicker);
            command.Parameters.AddWithValue("@durasi_film_menit", tambahFilmControl1.Durasi);
            try
            {
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data berhasil dimasukkan!!!");
                    Console.WriteLine("{0} row/rows affected", count);
                }
                else
                {
                    MessageBox.Show("Data tidak berhasil diinput, Try Again!!!");
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error Data tidak berhasil diInput\n" + error.Message);
            }
            connection.Close();
        }
        private void MenghapusData(string id_film)
        {
            try {
                CheckConnectionState(); 
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM daftar_film WHERE id_film = @idFilm";
                command.Parameters.AddWithValue("@idFilm", id_film);
                int count = command.ExecuteNonQuery();
                connection.Close();
                if (count > 0)
                {
                    if (MessageBox.Show(string.Format("data dengan id {0} berhasil dihapus", id_film)) == System.Windows.Forms.DialogResult.OK)
                    {
                        GenerateItemList();
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

        }
        private void MengambilTampilanData(string id_film)
        {
            try
            {
                CheckConnectionState();
                tambahFilmButton.Text = "Tampil Film";
                tambahFilmControl1.BringToFront(EditOrInsert.Edit);
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT id_film,judul,sinopsis,gambar,nama_bioskop,lokasi,harga,jadwal_tayang,durasi_film_menit FROM daftar_film WHERE id_film = @idFilm";
                command.Parameters.AddWithValue("@idFilm", id_film);
                var reader = command.ExecuteReader();
                if (!reader.Read()) return;
                tambahFilmControl1.IdFilm = reader["id_film"].ToString();
                tambahFilmControl1.Judul = reader["judul"].ToString();
                tambahFilmControl1.Sinopsis = reader["sinopsis"].ToString();
                tambahFilmControl1.NamaBioskop = reader["nama_bioskop"].ToString();
                tambahFilmControl1.LokasiBioskop = reader["lokasi"].ToString();
                tambahFilmControl1.Harga = (int)reader["harga"];
                tambahFilmControl1.JadwalTimePicker = (DateTime)reader["jadwal_tayang"];
                tambahFilmControl1.Durasi = (int)reader["durasi_film_menit"];
                MemoryStream ms = new MemoryStream((byte[])reader["gambar"]);
                tambahFilmControl1.Gambar = Image.FromStream(ms);
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        private void UpdateDataToDatabase(string idFilm)
        {
            CheckConnectionState();
            var command = new MySqlCommand("UPDATE daftar_film SET judul = @judul,sinopsis = @sinopsis,gambar = @gambar,nama_bioskop = @nama_bioskop,lokasi = @lokasi,harga = @harga,jadwal_tayang = @jadwal_tayang,durasi_film_menit = @durasi_film_menit WHERE id_film = @id_film", connection);
            command.Parameters.AddWithValue("@id_film", idFilm);
            command.Parameters.AddWithValue("@judul", tambahFilmControl1.Judul);
            command.Parameters.AddWithValue("@sinopsis", tambahFilmControl1.Sinopsis);
            MemoryStream ms = new MemoryStream();
            tambahFilmControl1.Gambar.Save(ms, tambahFilmControl1.Gambar.RawFormat);
            byte[] img = ms.ToArray();
            command.Parameters.AddWithValue("@gambar", img);
            command.Parameters.AddWithValue("@nama_bioskop", tambahFilmControl1.NamaBioskop);
            command.Parameters.AddWithValue("@lokasi", tambahFilmControl1.LokasiBioskop);
            command.Parameters.AddWithValue("@harga", tambahFilmControl1.Harga);
            command.Parameters.AddWithValue("@jadwal_tayang", tambahFilmControl1.JadwalTimePicker);
            command.Parameters.AddWithValue("@durasi_film_menit", tambahFilmControl1.Durasi);
            try
            {
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data berhasil diperbaharui!!!");
                    Console.WriteLine("{0} row/rows affected", count);
                }
                else
                {
                    MessageBox.Show("Data tidak berhasil diperbaharui, Try Again!!!");
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error Data tidak berhasil diperbaharui\n" + error.Message);
            }
            connection.Close();
        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
