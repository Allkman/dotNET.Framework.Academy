using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotNET.Academy.L3
{
    class Program
    {
        private static List<string> songList = new List<string>
            {
                "Hollaback Girl", "Call Me Maybe", "Uptown Funk", "Shake it Off", "Party in the U.S.A.", "Sorry", "Firework", "No Scrubs"
            };
        static void Main(string[] args)
        {
            //CikloAprasymas();
            //Uzduotis3();

            //WhileCiklas();

            //SelectSong();
            Calculator();
            Console.ReadLine();
        }

        static void SelectSong()
        {
            int songNumber = 0;
            DisplaySongList();            
            while (songNumber > songList.Count || songNumber == 0)
            {
                var songNumberInput = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(songNumberInput.ToString(), out songNumber);
                if (songNumber > songList.Count || songNumber == 0)
                {
                    Console.WriteLine($"Please enter a correct song list number");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You have selected \"{songList[songNumber -1]}\""); // nes List<int> { 0,1,2,3,4, } pradeda nuo nulio o mano sarasas List<songs> { 1 2 3 ...

        }
        static void DisplaySongList()
        {            
            for (int i = 0; i < songList.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, songList[i]);
            }
            Console.WriteLine();
        }
        static void CikloAprasymas()
        {
            Console.WriteLine("Iveskite ciklo pradzia");
            int pradzia = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite ciklo pabaiga");
            int pabaiga = int.Parse(Console.ReadLine());

            if (pradzia > pabaiga)
            {
                Console.WriteLine("BLOGI REZIAI!!");
            }
            else
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine($"{i} {Math.Pow(i, 2)}");
                }
            }
        }
        static void Uzduotis3()
        {
            int suma = 0;
            for (int i = 0; i <= 1000; i++)
            {
                //Console.WriteLine(i);
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
        static void WhileCiklas()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            int suma = 0;
            while (skaicius > 0)
            {
                Console.WriteLine(skaicius);
                if (skaicius %2 == 0)
                {
                    suma += skaicius;
                }
                skaicius--;
            }
        }
        static void Calculator()
        {

            string kartoti = "Y";
            while (kartoti == "Y")
            {
            Console.Write("Iveskite pirma skaiciu: ");
            double num01 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Iveskite antra skaiciu: ");
            double num02 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Pasirinkite norima atlikti veiksma:");
            Console.WriteLine("+ - Prideti");
            Console.WriteLine("- - Atimti");
            Console.WriteLine("* - Sudauginti");
            Console.WriteLine("/ - Padalinti");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Rezultatas: {num01} + {num02} = " + (num01 + num02));
                        break;
                    case "-":
                        Console.WriteLine($"Rezultatas: {num01} - {num02} = " + (num01 - num02));
                        break;
                    case "*":
                        Console.WriteLine($"Rezultatas: {num01} * {num02} = " + (num01 * num02));
                        break;
                    case "/":
                        if (num02 == 0)
                        {
                            Console.WriteLine("Dalyba is nulio neleistina");
                        }
                        else
                        {
                        Console.WriteLine($"Rezultatas: {num01} / {num02} = " + (num01 / num02));
                        }
                        break;
                    default:
                        Console.WriteLine("Tokio veiksmo atlikti negalima");
                        Thread.Sleep(3000);
                        break;
                }
                Console.WriteLine("Ar norite kartoti T/N");
                kartoti = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
