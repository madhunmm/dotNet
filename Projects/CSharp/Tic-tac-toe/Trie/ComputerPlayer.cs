using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DS
{
    class ComputerPlayer : Player
    {
        private Trie memory;
        private TicTacToe game;
        private int playerNo;

        public ComputerPlayer(TicTacToe ttt, int playerNo)
        {
            this.playerNo = playerNo;
            String strFileName;
            if (playerNo == 1)
                strFileName = "Brain1.txt";
            else
                strFileName = "Brain2.txt";
            memory = new Trie();
            System.IO.StreamReader filereader = new System.IO.StreamReader(new System.IO.FileStream(strFileName,System.IO.FileMode.OpenOrCreate));
            while (!filereader.EndOfStream)
            {
                memory.add(filereader.ReadLine(), null);
            }
            game = ttt;
            filereader.Close();
        }

        public override void Learn(String strSolution, int playerNo)
        {
            String strFileName;
            if (playerNo == 1)
                strFileName = "Brain1.txt";
            else
                strFileName = "Brain2.txt";
            memory.add(strSolution,null);

            // Commit memory to file
            System.IO.StreamWriter filewriter = new System.IO.StreamWriter(new System.IO.FileStream(strFileName, System.IO.FileMode.Append));
            filewriter.WriteLine(strSolution);
            filewriter.Close();
        }

        public override char Move()
        {
            // First check if threathened
            int[][] grid = game.GetBoard();
            int gridSize = game.GetGridSize();
            int mark = GetMark();
            int otherMark;
            char defendChoice = ' ';
            char winningChoice = ' ';
            char choice = ' ';

            if (mark == 1)
                otherMark = 2;
            else
                otherMark = 1;

            // Players play either '1' or '2'
            int count;

            // Check rows
            for (int row = 0; row < gridSize; row++)
            {
                count = 0;
                for (int col = 0; col < gridSize; col++)
                {
                    if (grid[row][col] == otherMark)
                        count++;
                }
                if (count == gridSize - 1)
                {
                    // Defense
                    for (int col = 0; col < gridSize; col++)
                    {
                        if (grid[row][col] == 0)
                        {
                            defendChoice = (char)(row * gridSize + col + 97);
                        }
                    }
                }
            }

            // Check columns
            for (int col = 0; col < gridSize; col++)
            {
                count = 0;
                for (int row = 0; row < gridSize; row++)
                {
                    if (grid[row][col] == otherMark)
                        count++;
                }
                if (count == gridSize - 1)
                {
                    // Defense
                    for (int row = 0; row < gridSize; row++)
                    {
                        if (grid[row][col] == 0)
                        {
                            defendChoice = (char)(row * gridSize + col + 97);
                        }
                    }
                }
            }

            // Check positive diagonal
            count = 0;
            for (int row = 0, col = 0; (row < gridSize && col < gridSize); row++, col++)
            {
                if (grid[row][col] == otherMark)
                    count++;
            }
            if (count == gridSize - 1)
            {
                // Defense
                for (int row = 0, col = 0; (row < gridSize && col < gridSize); row++, col++)
                {
                    if (grid[row][col] == 0)
                    {
                        defendChoice = (char)(row * gridSize + col + 97);
                    }
                }
            }

            // Check negative diagonal
            count = 0;
            for (int row = 0, col = gridSize - 1; (row < gridSize && col >= 0); row++, col--)
            {
                if (grid[row][col] == otherMark)
                    count++;
            }
            if (count == gridSize - 1)
            {
                // Defense
                for (int row = 0, col = gridSize - 1; (row < gridSize && col >= 0); row++, col--)
                {
                    if (grid[row][col] == 0)
                    {
                        defendChoice = (char)(row * gridSize + col + 97);
                    }
                }
            }

            // See if we have learnt anything in the past
            ArrayList alPossibilities = (ArrayList)memory.getChildTries(game.GetMoves());
            
            if (alPossibilities != null)
            {
                if (alPossibilities.Count > 0)
                {
                    // For the time being, select the first possibility
                    Trie t = (Trie)alPossibilities[new Random().Next(alPossibilities.Count)];
                    if (t.getValue() != null)
                    {
                        winningChoice = t.getChar();
                    }
                    else
                    {
                        choice = t.getChar();
                    }
                }
                else
                {
                }
            }
            else
            {
                // Go for a random placement
                while (true)
                {
                    choice = (char)(new Random().Next(game.GetGridSize() * game.GetGridSize()) + 97);
                    if (game.IsEmpty(choice))
                        break;
                }
                
            }
            if (winningChoice != ' ')
                choice = winningChoice;
            else if (defendChoice != ' ')
                choice = defendChoice;
                
            return choice;
        }
    }
}
