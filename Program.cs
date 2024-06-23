using System;
using System.Collections.Generic;
using System.Linq;

namespace PSBB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of families: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the number of members in the family (separated by a space): ");
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length != n)
            {
                Console.WriteLine("Input must be equal with count of family");
                return;
            }

            List<int> familyMembers = input.Select(int.Parse).ToList();
            int busesRequired = CalculateMinimumBuses(familyMembers);

            Console.WriteLine($"Minimum bus required is: {busesRequired}");
        }

        static int CalculateMinimumBuses(List<int> familyMembers)
        {
            familyMembers.Sort();
            int buses = 0;

            int i = 0;
            int j = familyMembers.Count - 1;

            while (i <= j)
            {
                if (familyMembers[i] + familyMembers[j] <= 4)
                {
                    i++;
                }
                j--;
                buses++;
            }

            return buses;
        }
    }
}
