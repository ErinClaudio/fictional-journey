using System;

namespace GradeBook
{
    class Program
    {
            static void Main(string[] args)
            {
                var numbers = new []{12.6, 10.3, 13.1};
                var sum = 0.0;
                foreach(double number in numbers)
                {
                   sum += number; 
                }

                Console.WriteLine(sum); 

                if(args.Length > 0)
                {
                    Console.WriteLine($"Hello {args[0]}!");
                }
                else
                {
                    Console.WriteLine($"Hello");  
                }
            }
    }
}
