using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution_taquin
{
    class NodeTaquin : GenericNode
    {
        public int sizeTaquin { get; private set; } //the number of cells in one column or one line
        public int[,] state { get; set; } //a board state is a [,] array with -1 if the cell is empty
        public int NbHoles { get; private set; } //the number of empty cells

        public NodeTaquin (int size,int nbHoles) //not a priority, useful for a random generator of Taquin boards
        {
            state = new int[size,size];
            NbHoles = nbHoles; //temp
            //make a random Taquin
        }

        public NodeTaquin(int[,] board) //priority
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns false if the compared node isn't a NodeTaquin or is a different state than this node. Else, returns true.
        /// </summary>
        /// <param name="N2"></param>
        /// <returns></returns>
        public override bool IsEqual(GenericNode N2)
        {
            if (N2 is NodeTaquin)
            {
                NodeTaquin toCompare = (NodeTaquin)N2;
                for (int i = 0; i < sizeTaquin; i++)
                {
                    for (int j = 0; j < sizeTaquin; j++)
                    {
                        if (state[i, j] != toCompare.state[i, j]) return false;
                    }
                }
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Returns 1 because in the Taquin problem, every action costs 1, so arcs between states cost 1.
        /// </summary>
        /// <param name="N2"></param>
        /// <returns></returns>
        public override double GetArcCost(GenericNode N2)
        {
            return 1;
        }

        /// <summary>
        /// Returns if this state is the final state of the game
        /// </summary>
        /// <returns></returns>
        public override bool EndState()
        {
            int k = 0;
            foreach(int i in state)
            {
                // a [,] array like { {1,2,3},{4,5,6}} is indeed read 1 2 3 4 5 6 in foreach loop
                k++;
                if (k <= sizeTaquin*sizeTaquin - NbHoles)
                {
                    if (i != k) return false;
                }
                else
                {
                    if (i != -1) return false;
                }
            }
            return true;

        }
        /// <summary>
        /// Cette méthode est sans doute la plus importante. Elle doit retourner la liste exhaustive de tous les noeuds successeurs du noeud courant. 
        /// Il faut pour cela identifier toutes les transitions possibles,
        /// créer à chaque fois le noeud successeur qui correspond à l’état qui serait atteint et renvoyer la liste obtenue.
        /// </summary>
        /// <returns></returns>
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> possibilities = new List<GenericNode>();
            for (int i = 0; i < sizeTaquin; i++)
            {
                for (int j = 0; j < sizeTaquin; j++)
                {
                    if (state[i, j] == -1)
                    {
                        //then navigates the adjacent existing cells to create new NodeTaquins
                        //then add it to the possibilities list
                    }
                }
            }
            return possibilities;
        }

        /// <summary>
        /// Returns the heuristic cost of this state, which is the number of wrong cells
        /// </summary>
        /// <returns></returns>
        public override double CalculeHCost()
        {
            double Hcost = 0;
            int k = 0;
            foreach (int i in state)
            {
                k++;
                if (k <= sizeTaquin*sizeTaquin - NbHoles && i != k) Hcost += 1;
                else break;
            }
            return Hcost;
        }
    }
}
