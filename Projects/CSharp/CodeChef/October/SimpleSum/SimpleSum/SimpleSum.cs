using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSum
{
    class SimpleSum
    {
        static void Main(string[] args)
        {
            // Get the args
            // first arg is the number of test cases
            int iTestCases;
            Double dNValue, dMValue;
            int iTestCaseMaxBound = 10;
            String[] strInput = null;
            String strInputLine;
    
            int iCounter = 0;
            while (iCounter < iTestCaseMaxBound)
            {
                // Keep getting the input
                strInputLine = Console.ReadLine();
                if (strInputLine == null)
                {
                    break;
                }
                iTestCases = Int32.Parse(strInputLine);
                dNValue = dMValue = 0;
                for (int iTestCaseCount = 0; iTestCaseCount < iTestCases; iTestCaseCount++)
                {
                    strInputLine = Console.ReadLine();
                    if (strInputLine == null)
                    {
                        break;
                    }
                    strInput = strInputLine.Split(' ');
                    dNValue = Double.Parse(strInput[0]);
                    dMValue = Double.Parse(strInput[1]);

                    // We have the input.
                    // Solve
                    Double dSum = 0, dRem = 0;
                    for (int iCurrN = 1; iCurrN <= dNValue; iCurrN++)
                    {
                        dSum = dSum + Math.Pow(iCurrN, iCurrN);
                    }
                    dRem = dSum % dMValue;
                    Console.WriteLine(dRem.ToString());
                }
                iTestCaseMaxBound++;
            }
        }
    }
}
