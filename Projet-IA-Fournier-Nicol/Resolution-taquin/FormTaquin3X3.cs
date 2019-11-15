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
    public partial class FormTaquin3X3 : Form
    {
        public int[,] Board { get; set; }
        public TextBox[] Boutons { get; set; }
        public FormTaquin3X3()
        {
            InitializeComponent();
            Board = new int[3, 3];
            Random r = new Random();
            int alea = r.Next(3);
            if (alea == 0)
            {
                Board[0, 0] = 1;
                Board[0, 1] = -1;
                Board[0, 2] = 3;
                Board[1, 0] = 4;
                Board[1, 1] = 2;
                Board[1, 2] = -1;
                Board[2, 0] = 6;
                Board[2, 1] = 7;
                Board[2, 2] = 5;
            }
            else if (alea == 1)
            {
                Board[0, 0] = -1;
                Board[0, 1] = 1;
                Board[0, 2] = 2;
                Board[1, 0] = -1;
                Board[1, 1] = 4;
                Board[1, 2] = 3;
                Board[2, 0] = 6;
                Board[2, 1] = 7;
                Board[2, 2] = 5;
            }
            else if (alea == 2)
            {
                Board[0, 0] = 7;
                Board[0, 1] = 1;
                Board[0, 2] = 4;
                Board[1, 0] = 5;
                Board[1, 1] = 6;
                Board[1, 2] = 3;
                Board[2, 0] = 2;
                Board[2, 1] = -1;
                Board[2, 2] = -1;
            }

            RemplirTaquin();
        }

        public void RemplirTaquin()
        {
            tbTaquin0.Text = Board[0, 0].ToString();
            tbTaquin1.Text = Board[0, 1].ToString();
            tbTaquin2.Text = Board[0, 2].ToString();
            tbTaquin3.Text = Board[1, 0].ToString();
            tbTaquin4.Text = Board[1, 1].ToString();
            tbTaquin5.Text = Board[1, 2].ToString();
            tbTaquin6.Text = Board[2, 0].ToString();
            tbTaquin7.Text = Board[2, 1].ToString();
            tbTaquin8.Text = Board[2, 2].ToString();
        }

        private void btnResoudre_Click(object sender, EventArgs e)
        {
            SearchTree newTree = new SearchTree();
            newTree.RechercheSolutionAEtoile(new NodeTaquin(Board));
            System.Diagnostics.Debug.Write("fini");
        }
    }
}
