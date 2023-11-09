using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }

            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));

            
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("Sum of Array Elements: " + sum);

            
            double average = (double)sum / numbers.Length;
            Console.WriteLine("Average of Array Elements: " + average);

            Console.ReadLine(); 
        }
    }
}
    

