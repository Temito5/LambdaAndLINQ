using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to enter? : ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            //int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine($"{string.Join(" ", nums.OrderByDescending(x => x).Take(3))}");
        }
    }
}
