using System;
using System.Collections.Generic;
using System.Linq;

namespace StackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList() ;

            List<int> evenIdxNums = new List<int>();
            List<int> oddIdxNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenIdxNums.Add(nums[i]);
                }
                else //i % 2 != 0
                {
                    oddIdxNums.Add(nums[i]);
                }
            }

            oddIdxNums.Reverse();

            Console.Write(string.Join(", ", evenIdxNums));
            Console.Write(", ");
            Console.Write(string.Join(", ", oddIdxNums));
        }
    }
}

