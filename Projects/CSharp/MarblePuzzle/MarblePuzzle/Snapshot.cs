using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MarblePuzzle
{
    class Snapshot
    {
        private Grid game;
        private ArrayList possibilitiesList;
        private int currentPosition;

        public Snapshot()
        {
            currentPosition = 0;
            game = new Grid();
            possibilitiesList = new ArrayList();
        }
        public Snapshot(Snapshot ss)
        {
            currentPosition = ss.GetCurrentIndex();
            game = new Grid(ss.GetGame());
            possibilitiesList = new ArrayList(ss.GetPossibilities());
        }
        public Snapshot(int currentIndex, Grid game, ArrayList possibilitiesList)
        {
            this.currentPosition = currentIndex;
            this.game = new Grid(game);
            this.possibilitiesList = new ArrayList(possibilitiesList);
        }

        public void IncrementIndex()                            { currentPosition++; }
        public int GetCurrentIndex()                            { return currentPosition; }
        public Grid GetGame()                                   { return game; }
        public ArrayList GetPossibilities()                     { return possibilitiesList; }
        public void SetGame(Grid game)                          { this.game = new Grid(game); }
        public void SetPossibilities(ArrayList posibList)       { this.possibilitiesList = posibList; }
        public int GetPossibilitiesCount()                      { return possibilitiesList.Count; }
        
        public Move GetMove()
        {
            if (currentPosition < possibilitiesList.Count)
            {
                return (Move)possibilitiesList[currentPosition];
            }
            return null;
        }

        public Boolean ExhaustedPossibilities()
        {
            if (currentPosition < possibilitiesList.Count)
                return false;
            return true;
        }
    }
}
