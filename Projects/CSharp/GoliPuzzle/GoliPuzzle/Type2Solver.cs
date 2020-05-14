using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GoliPuzzle
{
    class Type2Solver : Solver
    {
        private Grid tempGrid;
        private Grid possibilitiesGrid;
       
        public Type2Solver(Grid problem) 
            : base(problem)
        {
            possibilitiesGrid = new Grid();
        }

        private void ComputePossibilities()
        {
            // Go to each and every location and check if it is a hole
            // If so, then check if it matches the row and column matches for a possibility
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    PossibilitiesContainer possibContainer = new PossibilitiesContainer();
                    ArrayList possibList = new ArrayList();

                    if ((Int32.Parse(problem.GetValueAt(row, col).ToString()) != -1) && (Int32.Parse(problem.GetValueAt(row, col).ToString()) == 0))
                    {
                        // Check boundary conditions for positive row move
                        if (row <= 4)
                        {
                            // Check if move exists
                            if ((Int32.Parse(problem.GetValueAt(row + 1, col).ToString()) == 1) &&
                                (Int32.Parse(problem.GetValueAt(row + 2, col).ToString()) == 1))
                            {
                                // Add positive row move
                                int fromSlot = (row + 2) * 7 + col;
                                int holeSlot = (row + 1) * 7 + col;
                                int toSlot = (row) * 7 + col;

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

                        possibContainer.SetList(possibList);
                        possibilitiesGrid.SetValueAt(row, col, possibContainer);
                    }
                }
            }
        }

        public override Grid Solve()
        {
            while (true)
            {
                if (!possibilitiesGrid.IsFinished())
                {

                    tempGrid = new Grid(problem);

                    ComputePossibilities();

                    for (int row = 0; row < 7; row++)
                    {
                        for (int col = 0; col < 7; col++)
                        {
                            PossibilitiesContainer possibContainer = (PossibilitiesContainer)possibilitiesGrid.GetValueAt(row, col);

                            // Make the move
                            Possibilities posib = (Possibilities)possibContainer.GetMove();
                            if (posib != null)
                            {
                                tempGrid.SetValueAt(posib.GetFromSlot(), 0);
                                tempGrid.SetValueAt(posib.GetToSlot(), 1);
                                tempGrid.SetValueAt(posib.GetHoleSlot(), 0);
                            }
                            possibContainer.IncrementCounter();

                            // Fillup the single possibilities and forget them.
                            // They are not required for the snapshot
                            if (possibContainer.GetCount() == 1)
                            {
                                possibilitiesGrid.SetValueAt(row, col, 0);
                            }

                        }
                    }

                    // Take snapshot
                    Snapshot snap = new Snapshot();
                    snap.SetGame(tempGrid);
                    snap.SetPossibilitiesGrid(possibilitiesGrid);
                    snapshots.SaveSnapshot(snap);

                    // Set the temp grid as the main grid for the next iteration
                    problem = new Grid(tempGrid);
                }
                else
                {
                    if (problem.GetResult() == 1)
                        break;
                    
                    // take the top most snapshot from the stack and set it as the main problem

                }
            }
            return problem;
        }
        
    }
}
