﻿using System;
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
    public partial class FormTaquin5X5 : Form
    {
        public int[,] Board { get; set; }

        static Random r;
        List<GenericNode> N_ouverts;
        List<GenericNode> N_fermes;
        public FormTaquin5X5()
        {
            InitializeComponent(); Board = new int[5, 5];
            r = new Random();

            GenererTaquin();
        }

        public void RemplirTaquin()
        {
            tbTaquin0.Text = Board[0, 0].ToString();
            tbTaquin1.Text = Board[0, 1].ToString();
            tbTaquin2.Text = Board[0, 2].ToString();
            tbTaquin3.Text = Board[0, 3].ToString();
            tbTaquin4.Text = Board[0, 4].ToString();
            tbTaquin5.Text = Board[1, 0].ToString();
            tbTaquin6.Text = Board[1, 1].ToString();
            tbTaquin7.Text = Board[1, 2].ToString();
            tbTaquin8.Text = Board[1, 3].ToString();
            tbTaquin9.Text = Board[1, 4].ToString();
            tbTaquin10.Text = Board[2, 0].ToString();
            tbTaquin11.Text = Board[2, 1].ToString();
            tbTaquin12.Text = Board[2, 2].ToString();
            tbTaquin13.Text = Board[2, 3].ToString();
            tbTaquin14.Text = Board[2, 4].ToString();
            tbTaquin15.Text = Board[3, 0].ToString();
            tbTaquin16.Text = Board[3, 1].ToString();
            tbTaquin17.Text = Board[3, 2].ToString();
            tbTaquin18.Text = Board[3, 3].ToString();
            tbTaquin19.Text = Board[3, 4].ToString();
            tbTaquin20.Text = Board[4, 0].ToString();
            tbTaquin21.Text = Board[4, 1].ToString();
            tbTaquin22.Text = Board[4, 2].ToString();
            tbTaquin23.Text = Board[4, 3].ToString();
            tbTaquin24.Text = Board[4, 4].ToString();
        }

        public void GenererTaquin()
        {
            int alea = r.Next(3);
            if (alea == 0)
            {
                Board[0, 0] = 1;
                Board[0, 1] = 2;
                Board[0, 2] = 3;
                Board[0, 3] = 4;
                Board[0, 4] = 5;
                Board[1, 0] = -1;
                Board[1, 1] = 6;
                Board[1, 2] = 7;
                Board[1, 3] = 8;
                Board[1, 4] = 9;
                Board[2, 0] = 11;
                Board[2, 1] = 12;
                Board[2, 2] = 13;
                Board[2, 3] = 10;
                Board[2, 4] = -1;
                Board[3, 0] = 16;
                Board[3, 1] = 17;
                Board[3, 2] = 18;
                Board[3, 3] = 14;
                Board[3, 4] = 15;
                Board[4, 0] = 21;
                Board[4, 1] = 22;
                Board[4, 2] = 23;
                Board[4, 3] = 20;
                Board[4, 4] = 19;
            }
            else if (alea == 1)
            {
                Board[0, 0] = 8;
                Board[0, 1] = 1;
                Board[0, 2] = 9;
                Board[0, 3] = 10;
                Board[0, 4] = 2;
                Board[1, 0] = 18;
                Board[1, 1] = 15;
                Board[1, 2] = 21;
                Board[1, 3] = 22;
                Board[1, 4] = 17;
                Board[2, 0] = 12;
                Board[2, 1] = 13;
                Board[2, 2] = -1;
                Board[2, 3] = -1;
                Board[2, 4] = 23;
                Board[3, 0] = 19;
                Board[3, 1] = 4;
                Board[3, 2] = 20;
                Board[3, 3] = 16;
                Board[3, 4] = 3;
                Board[4, 0] = 6;
                Board[4, 1] = 7;
                Board[4, 2] = 11;
                Board[4, 3] = 14;
                Board[4, 4] = 5;
            }
            else if (alea == 2)
            {
                Board[0, 0] = 7;
                Board[0, 1] = 1;
                Board[0, 2] = 20;
                Board[0, 3] = 13;
                Board[0, 4] = 4;
                Board[1, 0] = 12;
                Board[1, 1] = 21;
                Board[1, 2] = 3;
                Board[1, 3] = 22;
                Board[1, 4] = 10;
                Board[2, 0] = 23;
                Board[2, 1] = 16;
                Board[2, 2] = 18;
                Board[2, 3] = 15;
                Board[2, 4] = 5;
                Board[3, 0] = 9;
                Board[3, 1] = 6;
                Board[3, 2] = 11;
                Board[3, 3] = 8;
                Board[3, 4] = 19;
                Board[4, 0] = 2;
                Board[4, 1] = 17;
                Board[4, 2] = 14;
                Board[4, 3] = -1;
                Board[4, 4] = -1;
            }

            RemplirTaquin();
        }

        private void btnInitTaquin_Click(object sender, EventArgs e)
        {
            GenererTaquin();
        }

        private void btnResoudre_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            SearchTree newTree = new SearchTree();
            N_ouverts = newTree.RechercheSolutionAEtoile(new NodeTaquin(Board));

            lbCoupGagner.DataSource = N_ouverts;

            lblNbNoeudsOuvertsRes.Text = newTree.CountInOpenList().ToString();
            lblNbNoeudsFermesRes.Text = newTree.CountInClosedList().ToString();

            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            lblTempsCalculRes.Text = elapsedTime;

            newTree.GetSearchTree(trArbreExploration);
        }
    }
}
