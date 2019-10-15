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
        public int[,] state { get; set; } //a bord state is a [,] array with -1 if the cell is empty

        public NodeTaquin (int taille)
        {
            state = new int[taille,taille];
        }

        public override bool IsEqual(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        public override double GetArcCost(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            throw new NotImplementedException();
        }

        public override List<GenericNode> GetListSucc()
        {
            throw new NotImplementedException();
        }
        public override double CalculeHCost()
        {
            throw new NotImplementedException();
        }
    }
}
