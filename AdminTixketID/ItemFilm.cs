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
    public partial class ItemFilm : UserControl
    {
        private string idFilm;
        private Image gambar;
        private string judul;
        private string sinopsis;
        public Action<string> ambilData;
        public Action<string> hapusData;

        [Category("Custom Property")]
        public string Id_film { get { return idFilm; } set { idFilm = value; } }
        [Category("Custom Property")]
        public Image Gambar { get { return gambar; } set { gambar = value; gambarFilmBox.Image = value; } }
        [Category("Custom Property")]
        public string Judul { get { return judul; } set { judul = value; judulFilmText.Text = value; } }
        [Category("Custom Property")]
        public string Sinopsis { get { return sinopsis; } set { sinopsis = value; SinopsisFilmText.Text = value; } }


        public ItemFilm()
        {
            InitializeComponent();
        }

        private void EditFilmButton_Click(object sender, EventArgs e)
        {
            ambilData(Id_film);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            hapusData(Id_film);
        }
    }
}
