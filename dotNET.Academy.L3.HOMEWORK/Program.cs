using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotNET.Academy.L3.HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Uzduotis
            Console.WriteLine("Enter a word");
            string str = Console.ReadLine();
            str = StringLettersSwap(str);
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 2. Uzduotis
            Console.WriteLine("How many days have left until Friday?");
            CalculateDaysUntilFriday();
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 3. Uzduotis
            CalculateYourBMI();
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 4. Uzduotis

            ValidatePIN();

            Console.WriteLine();
            Console.WriteLine("Press any key to Continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 5. Uzduotis

            NumberGuessingGame();

            Console.WriteLine();
            Console.WriteLine("Press any key to Continue.");
            Console.ReadLine();
            Console.Clear();
            #endregion
        }

        private static void NumberGuessingGame()
        {
            var rnd = new Random();
            var secrectNumber = rnd.Next(1, 5);
            int guessedNumber = 0;
            Console.WriteLine("Try to guess a secret number from 1 to 10");

            while (guessedNumber != secrectNumber)
            {
                var userInput = int.TryParse(Console.ReadLine(), out guessedNumber);

                if (guessedNumber != secrectNumber && guessedNumber < secrectNumber)
                {
                    Console.WriteLine("Secret number is bigger than your guess");
                }
                else if (guessedNumber != secrectNumber && guessedNumber > secrectNumber)
                {
                    Console.WriteLine("Secret number is smaller than your guess");
                }
                else
                {
                    Console.WriteLine($"WELL DONE!!! The number was {secrectNumber}");
                    //jei i skliaustus ideti {userInput} tai ats butu True...
                }
            }
        }
        public static void ValidatePIN()
        {
            int pinCode = 1112;
            int userInput = 0;
            int guessCount = 0;
            var incorrectGuessesCount = 3;

            Console.Clear();
            Console.Write("Plese enter you PIN: ");
            //sukti while tol kol vartotojo ivestis nelygu pin kodui IR spejimu skaicius(kiekis) mazesnis uz galimu spejimu skaiciu (kieki)
            while (pinCode != userInput && guessCount < incorrectGuessesCount) 
            {
                int.TryParse(Console.ReadLine(), out userInput); //tikrinu vartotojo ivesti
                if (userInput != pinCode)
                {
                    guessCount++;
                    Console.WriteLine("PIN Code is incorrect. Please try again");
                    CardBlockedStatement(guessCount, incorrectGuessesCount);
                }
                else
                {
                    Console.WriteLine("Pin number is correct.");
                }
            }
        }
        private static void CardBlockedStatement(int guessCount, int incorrectGuessesCount)
        {
            if (guessCount == incorrectGuessesCount)
            {
                Console.WriteLine("Your card has been blocked");
                Console.WriteLine("ATM will self-destruct in: ");
                int seconds = 5; 
                //timer
                for (int i = seconds; i >= 1; i--)
                {
                    Console.WriteLine($"---= {i} =---");
                    Thread.Sleep(1000);
                }
            }
        }
        private static void CalculateYourBMI()
        {
            Console.WriteLine("BMI - Body Mass Index calculator");

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter yout weight:");
            int weight = int.Parse(Console.ReadLine());

            height = Math.Pow(height, 2);
            double bmi = weight / height;
            bmi = Math.Round(bmi, 2);

            Console.WriteLine($"Your BMI is: {bmi}");
        }

        private static void CalculateDaysUntilFriday()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            Console.WriteLine($"Today is: {dayOfWeek}");
            var friday = DayOfWeek.Friday;
            var daysLeftUntilFriday = friday - dayOfWeek;
            Console.WriteLine($"{daysLeftUntilFriday} day(s) left until Friday");
        }

        private static string StringLettersSwap(string str)
        {
            var sb = new StringBuilder(); //kuriu string builder objekta (sb)
            sb.Append(str); // sb objektui pridedu ivesta string`a (str)

            var tmp = sb[0]; //kuriu nauja laikina kintamaji kuriame saugau pirmaja "str" raide (char)
            //---------- swap`as -- //
            sb[0] = sb[sb.Length - 1]; //sulyginu(sutapatinu) pirmaja str raide su paskutiniaja
            sb[sb.Length - 1] = tmp; //sulyginu(sutapatinu) paskutiniaja str raide su pirmaja 
            //----------------------//
            str = sb.ToString(); //ivestam str stringui pritaukau sb (swap`a)
            Console.WriteLine(str);

            return str;
        }

    }
}