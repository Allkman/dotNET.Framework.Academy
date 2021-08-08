using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET.Academy.L2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Uzduotis
            //1. Uzduotis

            //var pi = Math.PI;
            //Console.WriteLine("Calculate a length of a circle");
            //Console.WriteLine("Enter radius");
            //double radius = double.Parse(Console.ReadLine());
            //double circleLength = 2 * pi * radius;
            //Console.WriteLine($"Circle length is: 2 x {pi} x {radius} = {circleLength}");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Calculate an area of a circle");
            //var square = Math.Pow(radius, 2);
            //var area = pi * square;
            //Console.WriteLine($"Circle area is: {pi} x {square} = {area}");
            #endregion
            #region 2. Uzduotis
            //2. Uzduotis

            //Console.WriteLine("Enter distance in meters");
            //double distanceKm = double.Parse(Console.ReadLine()) / 1000;
            //Console.WriteLine("Enter time in seconds");
            //double timeHourse = double.Parse(Console.ReadLine()) / 3600;

            //double speed = Math.Round(distanceKm / timeHourse, 2);

            //Console.WriteLine($"Speed is: {speed} km/h");
            //3. Uzduotis
            //Console.WriteLine("Iveskite varda");
            //var name01 = Console.ReadLine();
            //Console.WriteLine("Iveskite pavarde");
            //var surname01 = Console.ReadLine();
            //Console.WriteLine("Gimimo vieta");
            //var birthPlace = Console.ReadLine();

            //Console.WriteLine($"{name01} {surname01} poilsiauja {birthPlace}");
            #endregion
            #region 3. Uzduotis
            //Mokomes if statment
            //Console.WriteLine("Enter 1st number");
            //int num01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number");
            //int num02 = int.Parse(Console.ReadLine());

            //if (num01 > num02)
            //{
            //    Console.WriteLine("Pirmas skaicius didesnis uz antra");
            //}
            //else if (num01 < num02)
            //{
            //    Console.WriteLine("Pirmas skaicius mazesnis uz antra");

            //}
            //else
            //{ 
            //    Console.WriteLine("Skaiciai yra lygus");
            //}
            #endregion
            //4. Uzduotis. Balsavimas

            //Console.Write("Iveskite savo amziu: ");
            //var amzius = int.Parse(Console.ReadLine());
            //if (amzius >= 18 && amzius <= 150)
            //{
            //    Console.WriteLine("Balsuoti galite");
            //}
            //else if (amzius > 0 && amzius < 18)
            //{
            //    Console.WriteLine($"Balsuoti galėsite už {18-amzius} metu");
            //}
            //else
            //{
            //    Console.WriteLine("Jus jau mires arba dar negimes");
            //}
            //Console.WriteLine();

            //5
            //int a = 10;
            //int b = 20;
            //int c = 0;
            //if (a>b && a < 100)
            //{
            //    Console.WriteLine("Pirma salyga teisinga");
            //}
            //if (b > 0 && b>a)
            //{
            //    Console.WriteLine("Antra salyga teisinga");
            //}
            //if (a> b && a > c || a > 0)
            //{
            //    Console.WriteLine("Trecia salyga teisinga");
            //}
            //if (c >= 5 && c <=10 || c > a || c > b)
            //{
            //    Console.WriteLine("Ketvirta salyga teisinga");
            //}

            //6 
            Console.WriteLine("Pasirinkite is meniu");
            Console.WriteLine(
                      @"1 - Limonadas
                        2 - Kava
                        3 - Arbata
                        4 - Alus
                        5 - Vanduo"
);
            var pasirinkimas = Console.ReadLine();
            Console.Clear();
            switch (pasirinkimas)
            {
                case "Limonadas":
                    LimonadoMeniu();
                    break;
                case "Kava":
                    Console.WriteLine("Pasirinkote Kava");
                    KavosMeniu();
                    break;
                case "Arbata":
                    ArbatosMeniu();
                    break;
                case "Alus":
                    AlausMeniu();
                    break;
                case "Vanduo":
                    VandensMeniu();
                    break;
                default:
                    GrizimasIPirmaMeniu();
                    break;
            }

            Console.ReadLine();
        }

        private static void GrizimasIPirmaMeniu()
        {
            Console.WriteLine("Tokio pasirinkimo nera");
        }

        private static void VandensMeniu()
        {
            Console.WriteLine("Pasirinkote Vandeni");
        }

        private static void ArbatosMeniu()
        {
            Console.WriteLine("Pasirinkote Arbata");
        }

        private static void AlausMeniu()
        {
            Console.WriteLine("Pasirinkote Alu");
        }

        private static void LimonadoMeniu()
        {
            Console.WriteLine("Pasirinkote Limonada");
        }

        private static void KavosMeniu()
        {
            Console.WriteLine("1- Latte\n2- Espresso\n3- Capuccino");
            string kava = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Kiek sauksteliu cukraus noresite?");
            int sauksteliai = int.Parse(Console.ReadLine());
            Console.Clear();
            if (sauksteliai >= 5)
            {
                Console.WriteLine("DEMESIO! Rizikuojate susirgti cukriniu debetu");
                KavosMeniu();
            }
            else
            {
                    
            switch (kava)
            {
                case "1":
                    Console.WriteLine($"Prasome, Jusu Latte su {sauksteliai} sauksteliu(-iais) cukraus");
                    break;
                case "2":
                    Console.WriteLine($"Prasome, Jusu Espresso su {sauksteliai} sauksteliu(-iais) cukraus");
                    break;
                case "3":
                    Console.WriteLine($"Prasome, Jusu Capuccino su {sauksteliai} sauksteliu(-iais) cukraus");
                    break;
                default:
                    break;
            }
            }
           
        }
    }
}
