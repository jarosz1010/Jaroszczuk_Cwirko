using System;

namespace Zadanie2
{

    public static class Kalkulator
    {
       
        public static double BasicOp(char operation, double value1, double value2)
        {
            double wynik = 0;
            switch (operation)
            {
                case '+':
                    wynik = value1 + value2;
                    break;
                case '-':
                    wynik = value1 - value2;
                    break;
                case '*':
                    wynik = value1 * value2;
                    break;
                case '/':
                    wynik = value1 / value2;
                    break;
            }
            return wynik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
