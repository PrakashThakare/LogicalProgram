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

            Console.WriteLine("Enter Number For Reverse Digits");
            int iNo = Convert.ToInt32(Console.ReadLine());
            ReverseNO.ReverseNumber(iNo);
            Console.ReadLine();
        }
    }
}
