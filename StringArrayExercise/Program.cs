using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your string: ");
            string input = Console.ReadLine();
            char[] inputCharactor = input.ToCharArray();

            for (int i = inputCharactor.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(inputCharactor[i] + " ");
                }
                else
                {
                    Console.Write(inputCharactor[i] + ", ");
                }
            }
        }
    }
}
