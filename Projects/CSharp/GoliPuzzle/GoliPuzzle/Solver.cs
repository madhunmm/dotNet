using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GoliPuzzle
{
    abstract class Solver
    {
        protected Grid problem;
        protected ArrayList possibList;
        protected SnapshotStack snapshots;

        public Solver(Grid problem)
        {
            this.problem = new Grid(problem);
            this.possibList = new ArrayList();
            snapshots = new SnapshotStack();
        }

        abstract public Grid Solve();
        
        protected void SetProblem(Grid pr)
        {
            this.problem = new Grid(pr);
        }

        protected void SetPossibilities(ArrayList posib)
        {
            this.possibList = new ArrayList(posib);
        }
    }

}
