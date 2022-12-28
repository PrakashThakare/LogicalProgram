using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciNo
    {
       public static void FibonacciNO(int iValue)
        {
            int iValue2 = 1, iSum = 0,iValue3=0;
            for (int iCnt=0 ; iCnt<iValue ; iCnt++)
            {
                iSum =iValue3+iValue2; 
                iValue3 = iValue2; 
                iValue2 = iSum;
                Console.WriteLine(iSum);
            }
        }
    }
}
