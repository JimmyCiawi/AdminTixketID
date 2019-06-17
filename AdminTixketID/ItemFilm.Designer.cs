namespace AdminTixketID
{
    partial class ItemFilm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gambarFilmBox = new System.Windows.Forms.PictureBox();
            this.judulFilmText = new System.Windows.Forms.TextBox();
            this.SinopsisFilmText = new System.Windows.Forms.TextBox();
            this.EditFilmButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarFilmBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gambarFilmBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 147);
            this.panel1.TabIndex = 0;
            // 
            // gambarFilmBox
            // 
            this.gambarFilmBox.Location = new System.Drawing.Point(3, 3);
            this.gambarFilmBox.Name = "gambarFilmBox";
            this.gambarFilmBox.Size = new System.Drawing.Size(141, 141);
            this.gambarFilmBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gambarFilmBox.TabIndex = 0;
            this.gambarFilmBox.TabStop = false;
            // 
            // judulFilmText
            // 
            this.judulFilmText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.judulFilmText.Enabled = false;
            this.judulFilmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulFilmText.Location = new System.Drawing.Point(153, 12);
            this.judulFilmText.MinimumSize = new System.Drawing.Size(500, 30);
            this.judulFilmText.Name = "judulFilmText";
            this.judulFilmText.ReadOnly = true;
            this.judulFilmText.Size = new System.Drawing.Size(745, 30);
            this.judulFilmText.TabIndex = 1;
            this.judulFilmText.Text = "Judul Film";
            // 
            // SinopsisFilmText
            // 
            this.SinopsisFilmText.Enabled = false;
            this.SinopsisFilmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinopsisFilmText.Location = new System.Drawing.Point(153, 48);
            this.SinopsisFilmText.MinimumSize = new System.Drawing.Size(500, 30);
            this.SinopsisFilmText.Multiline = true;
            this.SinopsisFilmText.Name = "SinopsisFilmText";
            this.SinopsisFilmText.ReadOnly = true;
            this.SinopsisFilmText.Size = new System.Drawing.Size(855, 96);
            this.SinopsisFilmText.TabIndex = 2;
            this.SinopsisFilmText.Text = "Judul Film";
            // 
            // EditFilmButton
            // 
            this.EditFilmButton.Location = new System.Drawing.Point(959, 12);
            this.EditFilmButton.Name = "EditFilmButton";
            this.EditFilmButton.Size = new System.Drawing.Size(49, 30);
            this.EditFilmButton.TabIndex = 3;
            this.EditFilmButton.Text = "Edit";
            this.EditFilmButton.UseVisualStyleBackColor = true;
            this.EditFilmButton.Click += new System.EventHandler(this.EditFilmButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(904, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(49, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ItemFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.EditFilmButton);
            this.Controls.Add(this.SinopsisFilmText);
            this.Controls.Add(this.judulFilmText);
            this.Controls.Add(this.panel1);
            this.Name = "ItemFilm";
            this.Size = new System.Drawing.Size(1013, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gambarFilmBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gambarFilmBox;
        private System.Windows.Forms.TextBox judulFilmText;
        private System.Windows.Forms.TextBox SinopsisFilmText;
        private System.Windows.Forms.Button EditFilmButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
