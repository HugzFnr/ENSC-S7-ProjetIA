using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolution_taquin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTaquin3X3_Click(object sender, EventArgs e)
        {
            FormTaquin3X3 form = new FormTaquin3X3();
            form.ShowDialog();
        }

        private void btnTaquin5X5_Click(object sender, EventArgs e)
        {
            FormTaquin5X5 form = new FormTaquin5X5();
            form.ShowDialog();
        }
    }
}
