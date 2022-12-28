using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNo
    {
        public static void PrimeNumber(int iValue)
        {
          
            for(int iCnt =2;iCnt<=(iValue/2);iCnt++)
            {
                if(iValue%iCnt!=0)
                {
                    Console.WriteLine("Number is Not Prime Number");
                    return;
                }
                
            }
            Console.WriteLine("Number is Prime Number ");
          
        }
    }
}
