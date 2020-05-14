using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarblePuzzle
{
    class Move
    {
        private int fromSlot;
        private int toSlot;
        private int holeSlot;

        public Move()
        {
        }

        public Move(int from, int to, int hole)
        {
            fromSlot = from;
            toSlot = to;
            holeSlot = hole;
        }

        public int GetFromSlot() { return fromSlot; }
        public int GetToSlot() { return toSlot; }
        public int GetHoleSlot() { return holeSlot; }
    }
}
