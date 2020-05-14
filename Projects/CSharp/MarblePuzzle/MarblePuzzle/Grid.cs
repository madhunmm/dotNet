using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarblePuzzle
{
    class Grid
    {
        private Object[,] matrix;

        public Grid()
        {
            matrix = new Object[7, 7];

            for (int i = 0; i < 49; i++)
            {
                SetValueAt(i, 0);
            }
        }

        public Grid(Grid gd)
        {
            matrix = new Object[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.matrix[i, j] = gd.matrix[i, j];
                }
            }
        }

        public Grid(Object[,] obj)
        {
            matrix = new Object[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.matrix[i, j] = obj[i, j];
                }
            }
        }

        public Object GetValueAt(int cellIndex)
        {
            int row = cellIndex / 7;
            int col = cellIndex % 7;
            return matrix[row, col];
        }

        public Object GetValueAt(int row, int col)
        {
            return matrix[row, col];
        }

        public void SetValueAt(int cellIndex, Object value)
        {
            int row = cellIndex / 7;
            int col = cellIndex % 7;
            matrix[row, col] = value;
        }

        public void SetValueAt(int row, int col, Object value)
        {
            matrix[row, col] = value;
        }

        public int GetResult()
        {
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matrix[i, j].Equals(1))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void Display()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if(matrix[i, j].ToString() == "-1")
                        Console.Write("-" + "\t");
                    else
                        Console.Write(matrix[i, j].ToString() + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public Boolean IsFinished()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (Int32.Parse(matrix[i, j].ToString()) <= 0)
                        return false;
                }
            }
            return true;
        }
    }
}
