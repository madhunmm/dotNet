using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoliPuzzle
{
    class Possibilities
    {
        private int fromSlot;
        private int toSlot;
        private int holeSlot;

        public Possibilities()
        {
        }

        public Possibilities(int from, int to, int hole)
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
