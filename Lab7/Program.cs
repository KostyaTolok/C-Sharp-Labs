using System;
using System.Threading;
namespace Task1
{
    class Program
    {
        static RationalNumber InputNumber()
        {
            Console.Clear();
            int whole, natural;
            Console.WriteLine("Enter number:");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter N:");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    whole = temp;
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Wrong N");
                Thread.Sleep(500);
                Console.Clear();
            }
            while (true)
            {
                Console.WriteLine("Enter M:");
                if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
                {
                    natural = temp;
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Wrong M");
                Thread.Sleep(500);
                Console.Clear();
            }
            return new RationalNumber(whole, natural);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            Thread.Sleep(500);
            RationalNumber number1 = InputNumber();
            Console.WriteLine("Enter second number:");
            Thread.Sleep(500);
            RationalNumber number2 = InputNumber();
            Console.WriteLine("First number: " + number1);
            string value1 = Convert.ToString(number1.Value);
            Console.WriteLine("First number value: " + value1);
            Console.WriteLine("Second number: " + number2);
            string value2 = Convert.ToString(number2.Value);
            Console.WriteLine("Second number value: " + value2);
            Console.WriteLine($"{number1}+{number2}={number1 + number2}");
            Console.WriteLine($"{number1}-{number2}={number1 - number2}");
            Console.WriteLine($"{number1}*{number2}={number1 * number2}");
            try
            {
                Console.WriteLine($"{number1}:{number2}={number1 / number2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            RationalNumber number3 = new RationalNumber();
            number3.ConvertFromFraction(number1.ToString());
            Console.WriteLine($"Converted from {number1} to class object: {number3}");
            RationalNumber number4 = number2.ConvertFromValue(value2);
            Console.WriteLine($"Converted from {number2.Value} to class object: {number4}");
            double x = (double)number1;
            int y = (int)number2;
            Console.WriteLine($"Explicit Conversion from {number1} to double: {x}");
            Console.WriteLine($"Explicit Conversion from {number2} to int: {y}");
        }
    }
}
