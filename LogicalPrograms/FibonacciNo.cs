using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciNo
    {
        public static void PerfectNumber(int iValue)
        {
            int iSum = 0;
            for (int iCnt = 1; iCnt <= (iValue / 2); iCnt++)
            {
                if ((iValue % iCnt) == 0)
                {
                    iSum += iCnt;
                }
            }
            if (iSum == iValue)
            {
                Console.WriteLine("it is Perfect Number");
            }
            else
            {
                Console.WriteLine("it is not Perfect Number" + iSum);
            }
        }
    }
}
