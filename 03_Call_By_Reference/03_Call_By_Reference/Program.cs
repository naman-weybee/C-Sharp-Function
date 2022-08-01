using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_By_Reference
{
    public class Program
    {
        public void show(ref int val)
        {
            val = val * val;
            Console.WriteLine("value inside the function: " + val);
        }

        public static void Main(string[] args)
        {
            int val = 5;
            Program program = new Program();
            Console.WriteLine("value before calling the function: " + val);
            program.show(ref val);
            Console.WriteLine("value after calling the function: " + val);
            Console.ReadLine();
        }
    }
}
