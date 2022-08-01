using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter
{
    public class Program
    {
        public void show(out int val1)
        {
            val1 = 10;
            Console.WriteLine("value inside the function: " + val1);
        }
        public void show1(out int val1, out int val2)
        {
            int newval = 10;
            val1 = newval;
            val2 = newval;
            val1 *= val1;
            val2 *= val2;
            Console.WriteLine("value1 inside the function: " + val1 + "\n" + "value2 inside the function: " + val2);
        }
        public static void Main(string[] args)
        {
            int val1 = 50;
            int val2 = 70;
            Program program = new Program();
            Console.WriteLine("value1 before calling the function: " + val1 + "\n" + "value2 before calling the function: " + val2);
            program.show1(out val1, out val2);
            Console.WriteLine("value1 after calling the function: " + val1 + "\n" + "value2 after calling the function: " + val2);
            Console.ReadLine();
        }
    }
}
