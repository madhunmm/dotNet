using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    public abstract class Player
    {
        private int symbol;
        public abstract char Move();

        public int GetMark()
        {
            return symbol;
        }
        public void SetMark(int num)
        {
            symbol = num;
        }

        public abstract void Learn(String strSolution, int playerNo);
    }
}
