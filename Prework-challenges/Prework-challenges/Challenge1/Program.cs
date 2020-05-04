using System;
using System.Runtime.InteropServices.ComTypes;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[5];
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                inputs[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number to score");
            int testNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                if( testNumber == inputs[i])
                {
                    count++;
                }
            }
            int score = count * testNumber;
            Console.WriteLine("The score is " + score);
            Console.ReadLine();
        }
    }
}
