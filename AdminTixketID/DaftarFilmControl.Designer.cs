namespace AdminTixketID
{
    partial class DaftarFilmControl
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
            this.filmLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // filmLayout
            // 
            this.filmLayout.AutoScroll = true;
            this.filmLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.filmLayout.Location = new System.Drawing.Point(0, 0);
            this.filmLayout.Name = "filmLayout";
            this.filmLayout.Size = new System.Drawing.Size(1045, 476);
            this.filmLayout.TabIndex = 0;
            // 
            // DaftarFilmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filmLayout);
            this.Name = "DaftarFilmControl";
            this.Size = new System.Drawing.Size(1045, 476);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel filmLayout;

    }
}
