using System;
namespace Inlämning_4.__3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<101;i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}