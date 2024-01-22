using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayHiUser("Monde");

            SayHiAge("Monde ", 23);
                Console.ReadLine();


        }

        private static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        private static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        private static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
