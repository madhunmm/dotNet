using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GoliPuzzle
{
    class Snapshot
    {
        private Grid game;
        private Grid possibilitiesGrid;

        public Snapshot()
        {
            game = new Grid();
            possibilitiesGrid = new Grid();
        }

        public Grid GetGame()                           { return game; }
        public Grid GetPossibilitiesGrid()             { return possibilitiesGrid; }
        public void SetGame(Grid game)                  { this.game = new Grid(game); }
        public void SetPossibilitiesGrid(Grid posib)   { this.possibilitiesGrid = new Grid(posib); }
    }
}
