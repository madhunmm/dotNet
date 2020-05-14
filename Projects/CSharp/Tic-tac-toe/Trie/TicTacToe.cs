using System;
using System.Collections;

namespace DS
{
    public class TicTacToe : Trie
    {
        private String strMoves;
        private int[][] grid;
        private int gridSize;

        private Player player1;
        private Player player2;

        private Player humanPlayer;

        private UI ui;

        public TicTacToe(UI ui, int num, int firstPlayer)
        {
            this.ui = ui;
            grid = new int[num][];
            for (int i = 0; i < num; i++)
            {
                grid[i] = new int[num];
            }
            gridSize = num;

            if (firstPlayer == 0)
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer(this, 2);
                humanPlayer = player1;
            }
            else if (firstPlayer == 1)
            {
                player1 = new ComputerPlayer(this, 1);
                player2 = new HumanPlayer();
                humanPlayer = player2;
            }
            player1.SetMark(1);
            player2.SetMark(2);
            strMoves = "";
        }

        public Player GetHumanPlayer()
        {
            return humanPlayer;
        }

        public void Play()
        {
            Player currentPlayer = player1;
            while (!IsEndOfGame())
            {
                //PrintBoard();
                MakeMove(currentPlayer.Move(),currentPlayer.GetMark());

                int result = IsSolution();
                if (result != 0)
                {
                    //PrintBoard();
                    if (result == 1)
                        ui.setResult(1);
                    else
                        ui.setResult(2);
                    player1.Learn(strMoves,result);
                    player2.Learn(strMoves,result);
                    break;
                }
                if (currentPlayer == player1)
                    currentPlayer = player2;
                else
                    currentPlayer = player1;
            }
            Console.WriteLine("Game over");
        }

        // Accessors
        public String GetMoves()
        {
            return strMoves;
        }

        public int GetGridSize()
        {
            return gridSize;
        }

        public void MakeMove(char position, int value)
        {
            int pos = position - 97;
            int row = pos / gridSize;
            int col = pos % gridSize;

            grid[row][col] = value;

            // record the move
            strMoves = strMoves + position.ToString();
        }

        private int IsSolution()
        {
            // Players play either '1' or '2'
            int count0, count1;
            
            // Check rows
            for (int row = 0; row < gridSize; row++)
            {
                count0 = 0;
                count1 = 0;
                for (int col = 0; col < gridSize; col++)
                {
                    if (grid[row][col] == 1)
                        count0++;
                    if (grid[row][col] == 2)
                        count1++;
                }
                if (count0 == gridSize)
                    return 1;
                if (count1 == gridSize)
                    return 2;
            }

            // Check columns
            for (int col = 0; col < gridSize; col++)
            {
                count0 = 0;
                count1 = 0;
                for (int row = 0; row < gridSize; row++)
                {
                    if (grid[row][col] == 1)
                        count0++;
                    if (grid[row][col] == 2)
                        count1++;
                }
                if (count0 == gridSize)
                    return 1;
                if (count1 == gridSize)
                    return 2;
            }

            // Check positive diagonal
            count0 = 0;
            count1 = 0;
            for(int row=0,col=0;(row<gridSize && col<gridSize);row++,col++)
            {
                if (grid[row][col] == 1)
                    count0++;
                if (grid[row][col] == 2)
                    count1++;
            }
            if (count0 == gridSize)
                return 1;
            if (count1 == gridSize)
                return 2;

            // Check negative diagonal
            count0 = 0;
            count1 = 0;
            for (int row = 0, col = gridSize-1; (row < gridSize && col >= 0); row++, col--)
            {
                if (grid[row][col] == 1)
                    count0++;
                if (grid[row][col] == 2)
                    count1++;
            }
            if (count0 == gridSize)
                return 1;
            if (count1 == gridSize)
                return 2;

            // No solution
            return 0;
        }
        private Boolean IsEndOfGame()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (grid[row][col] == 0)
                        return false;
                }
            }
            return true;
        }
        public void PrintBoard()
        {
            Console.WriteLine("==============");
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Console.Write(grid[row][col] + "  ");
                }
                Console.WriteLine();
            }
        }
        public Boolean IsEmpty(int cell)
        {
            int pos = cell - 97;
            int row = pos / gridSize;
            int col = pos % gridSize;
            if (grid[row][col] == 0)
                return true;
            return false;
        }

        public int[][] GetBoard()
        {
            return grid;
        }
    }
}
