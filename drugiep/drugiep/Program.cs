using System;
using System.Collections.Generic;

using System.Text;

namespace Fizzer
{
    public class FizzBuzz
    {
        public static List<string> MillNumbers(List<int> numbers)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
        
                bool piec = numbers[i].ToString().Contains(5.ToString());
                bool piec_trzy = numbers[i].ToString().Contains(53.ToString());
                bool trzy_piec = numbers[i].ToString().Contains(35.ToString());

              
                if (numbers[i] % 7 == 0)
                    result.Add("Buzzinga");
                else if ((numbers[i] % 3 == 0 && numbers[i] % 5 == 0) || piec_trzy || trzy_piec)
                    result.Add("FizzBuzz");
                else if (numbers[i] % 5 == 0 || piec)
                    result.Add("Buzz");
                else if (numbers[i] % 3 == 0)
                    result.Add("Fizz");
                else
                    result.Add(numbers[i].ToString());
            }
            return result;
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
