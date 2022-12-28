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

            Console.WriteLine("Enter Number For Check Perfect Or Not");
            int iNo = Convert.ToInt32(Console.ReadLine());
            FibonacciNo.PerfectNumber(iNo);
            Console.ReadLine();
        }
    }
}
