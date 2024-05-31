using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            double kgVal = 0.45359237;
            double poundVal = 2.20462262;

            Console.WriteLine("1. Convert pounds to kilograms.");
            Console.WriteLine("2. Convert kilograms to pounds.");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value in pounds: ");
                    int pounds = int.Parse(Console.ReadLine());
                    var toKg = pounds * kgVal;
                    Console.WriteLine($"{pounds} lbs = {Math.Round(toKg)} kg");
                    break;
                
                case 2:
                    Console.Write("Enter value in kilograms: ");
                    int kilograms = int.Parse(Console.ReadLine());
                    var toLb = kilograms * poundVal;
                    Console.WriteLine($"{kilograms} kg = {Math.Round(toLb)} lbs");
                    break;
            }
        }
    }
}