using System;

namespace Final1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            Console.WriteLine("Input char : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.", i + 1);
                number[i] = char.Parse(Console.ReadLine());
            }
            int min;
            for (int i = 0; i < n; i++)
            {
                min = i;
                for (int j = i; j < n; j++)
                {
                    min = j;
                }
                
            }
            Console.Write("Summation : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", number[i]);
            }
        }

        
    }
}
