using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public static void CouponNo(int iValue)
        {
            
            Random random = new Random();
            int iCheck = random.Next(1, 6);
            if(iCheck==iValue)
            {
                 Console.WriteLine("Coupon Number is : "+iCheck);
            }
            
        }
    }
}
