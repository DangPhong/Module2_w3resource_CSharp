using System;

namespace Ex48
{
    class Program
    {
        //Write a C# program to check if the first element and the last element are equal of an array of integers
        //and the length is 1 or more.
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(nums.Length > 1 && nums[0].Equals(nums[nums.Length - 1]));
        }
    }
}
