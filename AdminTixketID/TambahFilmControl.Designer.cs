namespace AdminTixketID
{
    partial class TambahFilmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.idFilmText = new System.Windows.Forms.TextBox();
            this.judulText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namaBioskopText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lokasiBioskopText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hargaText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durasiText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jadwalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gambarBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sinopsisText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Film";
            // 
            // idFilmText
            // 
            this.idFilmText.Location = new System.Drawing.Point(139, 18);
            this.idFilmText.Name = "idFilmText";
            this.idFilmText.Size = new System.Drawing.Size(202, 22);
            this.idFilmText.TabIndex = 1;
            // 
            // judulText
            // 
            this.judulText.Location = new System.Drawing.Point(139, 76);
            this.judulText.Name = "judulText";
            this.judulText.Size = new System.Drawing.Size(202, 22);
            this.judulText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Judul";
            // 
            // namaBioskopText
            // 
            this.namaBioskopText.Location = new System.Drawing.Point(139, 201);
            this.namaBioskopText.Name = "namaBioskopText";
            this.namaBioskopText.Size = new System.Drawing.Size(202, 22);
            this.namaBioskopText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Bioskop";
            // 
            // lokasiBioskopText
            // 
            this.lokasiBioskopText.Location = new System.Drawing.Point(139, 257);
            this.lokasiBioskopText.Name = "lokasiBioskopText";
            this.lokasiBioskopText.Size = new System.Drawing.Size(202, 22);
            this.lokasiBioskopText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lokasi Bioskop";
            // 
            // hargaText
            // 
            this.hargaText.Location = new System.Drawing.Point(139, 311);
            this.hargaText.MaxLength = 11;
            this.hargaText.Name = "hargaText";
            this.hargaText.Size = new System.Drawing.Size(202, 22);
            this.hargaText.TabIndex = 6;
            this.hargaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga";
            // 
            // durasiText
            // 
            this.durasiText.Location = new System.Drawing.Point(139, 366);
            this.durasiText.Name = "durasiText";
            this.durasiText.Size = new System.Drawing.Size(202, 22);
            this.durasiText.TabIndex = 7;
            this.durasiText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durasi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jadwal Tayang";
            // 
            // jadwalTimePicker
            // 
            this.jadwalTimePicker.Location = new System.Drawing.Point(141, 426);
            this.jadwalTimePicker.Name = "jadwalTimePicker";
            this.jadwalTimePicker.Size = new System.Drawing.Size(366, 22);
            this.jadwalTimePicker.TabIndex = 8;
            this.jadwalTimePicker.Value = new System.DateTime(2019, 12, 26, 0, 0, 0, 0);
            // 
            // gambarBox
            // 
            this.gambarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gambarBox.Location = new System.Drawing.Point(404, 18);
            this.gambarBox.Name = "gambarBox";
            this.gambarBox.Size = new System.Drawing.Size(300, 300);
            this.gambarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarBox.TabIndex = 14;
            this.gambarBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sinopsis";
            // 
            // sinopsisText
            // 
            this.sinopsisText.Location = new System.Drawing.Point(139, 123);
            this.sinopsisText.Multiline = true;
            this.sinopsisText.Name = "sinopsisText";
            this.sinopsisText.Size = new System.Drawing.Size(202, 58);
            this.sinopsisText.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(404, 342);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 41);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(534, 342);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(170, 41);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Masukkan ke Database";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // TambahFilmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.sinopsisText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gambarBox);
            this.Controls.Add(this.jadwalTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.durasiText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hargaText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lokasiBioskopText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namaBioskopText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.judulText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idFilmText);
            this.Controls.Add(this.label1);
            this.Name = "TambahFilmControl";
            this.Size = new System.Drawing.Size(1045, 476);
            this.Load += new System.EventHandler(this.TambahFilmControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idFilmText;
        private System.Windows.Forms.TextBox judulText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namaBioskopText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lokasiBioskopText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hargaText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durasiText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker jadwalTimePicker;
        private System.Windows.Forms.PictureBox gambarBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sinopsisText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button insertButton;
    }
}
