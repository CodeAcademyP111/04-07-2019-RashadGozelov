using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqemi daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            n.FindSimpleNumber();
        }
    }
}
