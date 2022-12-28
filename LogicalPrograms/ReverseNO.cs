using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNO
    {
        public static void ReverseNumber(int iValue)
        {
            int iDigit = 0, iRevs = 0;
            for(int iCnt=iValue ; iCnt>0 ; iCnt = iValue)
            {
                iDigit = iValue % 10;
                iRevs = (iRevs*10) + iDigit;
                iValue /= 10;
            }
            Console.WriteLine("Reverse Numbe is : "+iRevs);
        }
    }
}
