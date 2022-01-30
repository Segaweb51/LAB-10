using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
      
        }
    }
    class Cat
    {
        string name;
        string colore;
        int age;

        Cat(string n, string c, int a)
        {
            name = n;
            colore = c;
            age = a;
        }
        void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
