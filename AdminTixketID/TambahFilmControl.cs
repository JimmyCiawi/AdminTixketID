using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminTixketID
{
    public enum EditOrInsert { Edit, Insert };
    public partial class TambahFilmControl : UserControl
    {
        private string idFilmVar;
        private string judulVar;
        private string namaBioskopVar;
        private string lokasiBioskopVar;
        private int hargaVar;
        private int durasiVar;
        private DateTime jadwalTimePickerVar = DateTime.Now;
        private Image gambarVar;
        private string sinopsisVar;
        public Action browseImage;
        public Action insertAction;
        public Action<string> updateAction;

        public EditOrInsert currentState;

        [Category("Custom Property")]
        public string IdFilm { get { return idFilmText.Text; } set { idFilmVar = value; idFilmText.Text = value; } }
        [Category("Custom Property")]
        public string Judul { get { return judulText.Text; } set { judulVar = value; judulText.Text = value; } }
        [Category("Custom Property")]
        public string NamaBioskop { get { return namaBioskopText.Text; } set { namaBioskopVar = value; namaBioskopText.Text = value; } }
        [Category("Custom Property")]
        public string LokasiBioskop { get { return lokasiBioskopText.Text; } set { lokasiBioskopVar = value; lokasiBioskopText.Text = value; } }
        [Category("Custom Property")]
        public int Harga { get { return int.Parse(hargaText.Text); } set { hargaVar = value; hargaText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public int Durasi { get { return int.Parse(durasiText.Text); } set { durasiVar = value; durasiText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public DateTime JadwalTimePicker { get { return jadwalTimePicker.Value; } set { jadwalTimePickerVar = value; jadwalTimePicker.Value = value; } }
        [Category("Custom Property")]
        public Image Gambar { get { return gambarVar; } set { gambarVar = value; gambarBox.Image = value; } }
        [Category("Custom Property")]
        public string Sinopsis { get { return sinopsisText.Text; } set { sinopsisVar = value; sinopsisText.Text = value; } }
        
        public void BringToFront(EditOrInsert formState)
        {
            currentState = formState;
            this.BringToFront();
            if (formState == EditOrInsert.Edit)
            {
                idFilmText.Enabled = false;
                idFilmText.ReadOnly = true;
                insertButton.Text = "Simpan Perubahan";
            }
            else if (formState == EditOrInsert.Insert)
            {
                idFilmText.Clear();
                judulText.Clear();
                namaBioskopText.Clear();
                lokasiBioskopText.Clear();
                hargaText.Clear();
                durasiText.Clear();
                jadwalTimePicker.Value = DateTime.Now;
                gambarBox.Image = null;
                sinopsisText.Clear();
                idFilmText.Enabled = true;
                idFilmText.ReadOnly = false;
                insertButton.Text = "Masukkan Data";
            }
        }

        public TambahFilmControl()
        {
            InitializeComponent();
        }
        private void TambahFilmControl_Load(object sender, EventArgs e)
        {
            jadwalTimePicker.Format = DateTimePickerFormat.Custom;
            jadwalTimePicker.CustomFormat = "dddd MMMM dd,yyyy      HH:mm";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            browseImage();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (currentState == EditOrInsert.Insert) insertAction();
            else if (currentState == EditOrInsert.Edit) updateAction(IdFilm);
        }
    }
}
