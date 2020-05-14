using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarblePuzzle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            Object[,] grid = new Object[7, 7];
            //StringBuffer puzzle = new StringBuffer("461-83---2------1--5---26-4-3----257---------197----3-3-61---9--2------3---37-462");
            //StringBuffer puzzle = new StringBuffer("-8-----1-9-------54--179--3-4-7-3-6--72-4-83--9-6-8-5-8--935--21-------6-5-----7-");
            //StringBuffer puzzle = new StringBuffer("-8-9-3-7-6-3---4-1---------5---2---396--1--472---9---8---------4-5---6-2-2-5-1-3-");
            String puzzle = "--111----111--111111111101111111111--111----111--";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    int pos = (7 * i) + j;
                    if (puzzle[pos] != '-')
                        grid[i, j] = puzzle[pos] - 48;
                    else
                        grid[i, j] = -1;
                }
            }
            Grid game = new Grid(grid);
            Console.WriteLine("BEFORE SOLVING");
            game.Display();
            Solver solver = new Type1Solver(game);
            game = solver.Solve();
            Console.WriteLine("AFTER SOLVING");
            game.Display();
        }
    }
}
