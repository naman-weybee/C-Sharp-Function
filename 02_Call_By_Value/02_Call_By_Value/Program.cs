using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Call_By_Value
{
    public class Program
    {
        public void show(int val)
        {
            val = val * val;
            Console.WriteLine("value inside the function: " + val);
        }
        public static void Main(string[] args)
        {
            int val = 5;
            Program program = new Program();
            Console.WriteLine("value before calling the function: " + val);
            program.show(val);
            Console.WriteLine("value after calling the function: " + val);
            Console.ReadLine();
        }
    }
}
