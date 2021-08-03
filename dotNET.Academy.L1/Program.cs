using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotNET.Academy.L1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInputTest();
            Console.WriteLine("|-------------------------------------------------------------|");
            Console.WriteLine();

            Console.Write("Iveskite pirma skaiciu: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Iveskite antra skaiciu: ");
            double b = double.Parse(Console.ReadLine());

            double suma = a + b;
            double skirtumas = a - b;
            double sandauga = a * b;
            double dalmuo = a / b;

            Console.WriteLine($"{a} + {b} = {suma}");
            Console.WriteLine($"{a} - {b} = {skirtumas}");
            Console.WriteLine($"{a} x {b} = {sandauga}");
            Console.WriteLine($"{a} / {b} = {dalmuo}");

            Console.ReadLine();
        }
        private static void UserInputTest()
        {
            string name = "Algirdas";
            string surName = "Cernevicius";
            string hobby = "Programing";
            int age = 36;
            string city = "Vilnius";
            Console.WriteLine(
                $"Hello all,\nMy name is {name} {surName}.\nMy hobby is {hobby}.\nI am {age} years old.\nI am from {city}.");
            Console.WriteLine("|-------------------------------------------------------------|");
            Console.WriteLine();

            Console.Write("Iveskite savo varda: ");
            string name02 = Console.ReadLine();
            Console.Clear();
            Console.Write("Iveskite savo amziu: ");
            int age02 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Iveskite savo miesta: ");
            string city02 = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(2000);

            Console.WriteLine(
                $"Hello all,\nName is {name02}.\nAge {age02}.\nCity {city02}.");
        }
    }
}
