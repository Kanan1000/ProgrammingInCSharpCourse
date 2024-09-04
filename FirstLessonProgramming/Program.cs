using System;
using System.Net.Http;

namespace FirstLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            // console.writeline("hello c#");

            Console.WriteLine("Enter first number: ");
            int var1;
            while (true)
            {
                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("You can only enter int number!");
                }
            }

            Console.WriteLine("Enter second number: ");
            int var2 = int.Parse(Console.ReadLine());
            int sum = Sum(var1, var2);

            Console.WriteLine("sum is: " + sum);
            // Console.WriteLine(Sum(3, 12));
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

    }

}

