using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class Program
    {
        public void show()
        {
            Console.WriteLine("non parameterized function");
        }
        public void show1(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        public string show2(string msg)
        {
            Console.WriteLine("inside the function");
            return msg;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            string msg = program.show2("Jonas");
            Console.WriteLine("Hello " + msg);
            Console.ReadLine();
        }
    }
}
