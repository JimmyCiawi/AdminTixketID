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
    public partial class DaftarFilmControl : UserControl
    {
        [Category("Custom Property")]
        public FlowLayoutPanel FilmLayout { get { return filmLayout; } set { filmLayout = value; } }
        public DaftarFilmControl()
        {
            InitializeComponent();
        }
    }
}
