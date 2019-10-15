using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution_taquin
{
    class NodeTaquin : GenericNode
    {
        public int tailleTaquin { get; private set; }
        public int[][] state { get; set; }

        public NodeTaquin (int taille)
        {
            //state = new int[taille][taille];
        }
    }
}
