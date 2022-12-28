using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int []Arr = new int[5];
            Console.WriteLine("Enter Numbers For Coupon");
            for(int iCnt =0;iCnt<=Arr.Length-1;iCnt++)
            {
                Arr[iCnt] = Convert.ToInt32(Console.ReadLine());
            }

            for (int iCnt = 0; iCnt <= Arr.Length - 1; iCnt++)
            {
                CouponNumber.CouponNo(Arr[iCnt]);
            }

            Console.ReadLine();
        }
    }
}
