namespace AdminTixketID
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tambahFilmControl1 = new AdminTixketID.TambahFilmControl();
            this.daftarFilmControl1 = new AdminTixketID.DaftarFilmControl();
            this.tambahFilmButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tambahFilmControl1);
            this.panel1.Controls.Add(this.daftarFilmControl1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 476);
            this.panel1.TabIndex = 2;
            // 
            // tambahFilmControl1
            // 
            this.tambahFilmControl1.browseImage = null;
            this.tambahFilmControl1.Durasi = 0;
            this.tambahFilmControl1.Gambar = null;
            this.tambahFilmControl1.Harga = 1000;
            this.tambahFilmControl1.IdFilm = null;
            this.tambahFilmControl1.insertAction = null;
            this.tambahFilmControl1.JadwalTimePicker = new System.DateTime(2019, 6, 19, 0, 0, 0, 0);
            this.tambahFilmControl1.Judul = null;
            this.tambahFilmControl1.Location = new System.Drawing.Point(0, 0);
            this.tambahFilmControl1.LokasiBioskop = null;
            this.tambahFilmControl1.NamaBioskop = null;
            this.tambahFilmControl1.Name = "tambahFilmControl1";
            this.tambahFilmControl1.Sinopsis = null;
            this.tambahFilmControl1.Size = new System.Drawing.Size(1045, 476);
            this.tambahFilmControl1.TabIndex = 1;
            // 
            // daftarFilmControl1
            // 
            this.daftarFilmControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daftarFilmControl1.Location = new System.Drawing.Point(0, 0);
            this.daftarFilmControl1.Name = "daftarFilmControl1";
            this.daftarFilmControl1.Size = new System.Drawing.Size(1045, 476);
            this.daftarFilmControl1.TabIndex = 0;
            // 
            // tambahFilmButton
            // 
            this.tambahFilmButton.Location = new System.Drawing.Point(926, 11);
            this.tambahFilmButton.Name = "tambahFilmButton";
            this.tambahFilmButton.Size = new System.Drawing.Size(131, 37);
            this.tambahFilmButton.TabIndex = 3;
            this.tambahFilmButton.Text = "Tambah Film";
            this.tambahFilmButton.UseVisualStyleBackColor = true;
            this.tambahFilmButton.Click += new System.EventHandler(this.tambahFilm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 542);
            this.Controls.Add(this.tambahFilmButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Tixket ID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tambahFilmButton;
        private DaftarFilmControl daftarFilmControl1;
        private TambahFilmControl tambahFilmControl1;
    }
}

