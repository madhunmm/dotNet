using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GoliPuzzle
{
    class PossibilitiesContainer
    {
        private ArrayList possibList;
        private int currentPosition;

        public PossibilitiesContainer()
        {
            currentPosition = 0;
        }

        public int GetCount() { return possibList.Count; }
        public void IncrementCounter() { currentPosition ++; }
        public Possibilities GetMove() 
        {
            if (currentPosition >= possibList.Count)
                return null;
            return (Possibilities) possibList[currentPosition]; 
        }

        public void SetList(ArrayList possibList)
        {
            this.possibList = possibList;
        }

        public Boolean ExhaustedPossibilities()
        {
            if (currentPosition >= possibList.Count)
            {
                return true;
            }
            return false;
        }
    }
}
