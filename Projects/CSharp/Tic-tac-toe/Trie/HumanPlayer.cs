using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class HumanPlayer : Player
    {
        private char cMove;

        public HumanPlayer()
        {
            cMove = '0';
        }
        public override char Move()
        {
            while (cMove == '0')
            {
                System.Threading.Thread.Sleep(1000);
            }
            char c = cMove;
            cMove = '0';
            return c;
        }
        public override void Learn(string strSolution, int i)
        {
            // Do nothing
        }

        public void SetMove(char c)
        {
            cMove = c;
        }
    }
}
