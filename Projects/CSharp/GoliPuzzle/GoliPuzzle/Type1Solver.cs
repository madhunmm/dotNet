using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GoliPuzzle
{
    class Type1Solver : Solver
    {
        public Type1Solver(Grid problem) 
            : base(problem)
        {
        }

        private void ComputePossibilities()
        {
            // Go to each and every location and check if it is a hole
            // If so, then check if it matches the row and column matches for a possibility
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((Int32.Parse(problem.GetValueAt(row, col).ToString()) != -1) && (Int32.Parse(problem.GetValueAt(row, col).ToString()) == 0))
                    {
                        // Check boundary conditions for positive row move
                        if (row <= 4)
                        {
                            // Check if move exists
                            if ((Int32.Parse(problem.GetValueAt(row + 1,col).ToString()) == 1) &&
                                (Int32.Parse(problem.GetValueAt(row + 2,col).ToString()) == 1))
                            {
                                // Add positive row move
                                int fromSlot = (row+2) *7 + col;
                                int holeSlot = (row+1)*7 + col;
                                int toSlot = (row)*7 +col;

                                possibList.Add(new Possibilities(fromSlot, toSlot, holeSlot));
                            }
                        }
                        
                        // Check boundary conditions for negative row move
                        if (row >= 2)
                        {
                            // Check if move exists
                            if ((Int32.Parse(problem.GetValueAt(row - 1, col).ToString()) == 1) &&
                                (Int32.Parse(problem.GetValueAt(row - 2, col).ToString()) == 1))
                            {
                                // Add negative row move
                                int fromSlot = (row - 2) * 7 + col;
                                int holeSlot = (row - 1) * 7 + col;
                                int toSlot = (row) * 7 + col;

                                possibList.Add(new Possibilities(fromSlot, toSlot, holeSlot));
                            }
                        }

                        // Check boundary conditions for positive col move
                        if (col <= 4)
                        {
                            // Check if move exists
                            if ((Int32.Parse(problem.GetValueAt(row, col + 1).ToString()) == 1) &&
                                (Int32.Parse(problem.GetValueAt(row, col + 2).ToString()) == 1))
                            {
                                // Add positive column move
                                int fromSlot = (row) * 7 + col + 2;
                                int holeSlot = (row) * 7 + col + 1;
                                int toSlot = (row) * 7 + col;

                                possibList.Add(new Possibilities(fromSlot, toSlot, holeSlot));
                            }
                        }

                        // Check boundary conditions for negative col move
                        if (col >= 2)
                        {
                            // Check if move exists
                            if ((Int32.Parse(problem.GetValueAt(row, col - 1).ToString()) == 1) &&
                                (Int32.Parse(problem.GetValueAt(row, col - 2).ToString()) == 1))
                            {
                                // Add negative column move
                                int fromSlot = (row) * 7 + col - 2;
                                int holeSlot = (row) * 7 + col - 1;
                                int toSlot = (row) * 7 + col;

                                possibList.Add(new Possibilities(fromSlot, toSlot, holeSlot));
                            }
                        }
                    }
                }
            }
        }

        public override Grid Solve()
        {
            //// Do the initial snapshot (Initializing the solver)
            ComputePossibilities();

            //// Create Snapshot of the initial state
            //Snapshot ss = new Snapshot();
            //ss.SetGame(problem);
            //ss.SetPossibilities(possibilities);

            //// Add the snapshot to the stack
            //snapshots.SaveSnapshot(ss);

            //Snapshot sslatest = ss;

            Snapshot sslatest;
            // Do untill solution is reached
            while (true)
            {
                if (IsFinished())
                {
                    Console.WriteLine(problem.GetResult());
                    if (problem.GetResult() == 1)
                    {
                        break; // We are done
                    }
                    else
                    {
                        while (true)
                        {
                            // Make top of stack item as current problem
                            sslatest = snapshots.GetLatestSnapshot();
                            SetProblem(sslatest.GetGame());
                            SetPossibilities(sslatest.GetPossibilitiesGrid());
                            sslatest.IncrementIndex();

                            if (snapshots.GetLatestSnapshot().ExhaustedPossibilities())
                            {
                                snapshots.RemoveLatestSnapshot();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    possibList.Clear();
                    ComputePossibilities();

                    // Create Snapshot
                    Snapshot ssNew = new Snapshot();
                    ssNew.SetGame(problem);
                    ssNew.SetPossibilities(possibList);

                    // Add the snapshot to the stack
                    snapshots.SaveSnapshot(ssNew);

                    sslatest = ssNew;
                }

                // Make a move from the list of possibilities
                Possibilities posib = (Possibilities)possibList[sslatest.GetCurrentIndex()];
                problem.SetValueAt(posib.GetFromSlot(), 0);
                problem.SetValueAt(posib.GetToSlot(), 1);
                problem.SetValueAt(posib.GetHoleSlot(), 0);

                // Reset the Possibilities as we have now made a move 
                // and disturbed the earlier state
                possibList.Clear();
                ComputePossibilities();
                
                
            }
            return this.problem;
        }
       
        private Boolean IsFinished()
        {
            if (possibList.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
