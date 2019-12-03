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
        static Random r;

        public int[,] Board { get; set; }
        public FormTaquin3X3()
        {
            InitializeComponent();
            Board = new int[3, 3];
            r = new Random();
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
           lbCoupGagner.Items.Clear();
            SearchTree g = new SearchTree();
            NodeTaquin N0 = new NodeTaquin(Board);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            lblTempsCalculRes.Text = elapsedTime;

            if (Lres.Count != 0)
            {
                foreach (GenericNode N in Lres)
                {
                    lbCoupGagner.Items.Add(N);
                }
                lblNbNoeudsOuvertsRes.Text = g.CountInOpenList().ToString();
                lblNbNoeudsFermesRes.Text = g.CountInClosedList().ToString();
                g.GetSearchTree(trArbreExploration);
            }
        }

        private void btnChoixTaquin1_Click(object sender, EventArgs e)
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

            RemplirTaquin();
        }

        private void btnChoixTaquin2_Click(object sender, EventArgs e)
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

            RemplirTaquin();
        }

        private void btnChoixTaquin3_Click(object sender, EventArgs e)
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

            RemplirTaquin();
        }
    }
}
