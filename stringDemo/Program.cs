using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sattar";
           
            Console.WriteLine(name);
            Console.WriteLine(name[5]);

            //string lines = "line 1\nline2";
            string lines = "word 1\tword2";
            string directory = "C:\\Program\\C#";
            string myBook = "\"Golpe Golpe C Programming\" is an awesome book in C";
            Console.WriteLine(myBook);
        }
    }
}
