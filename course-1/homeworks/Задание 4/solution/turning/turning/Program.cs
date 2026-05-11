using System;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int[] rev_nums = new int[5];
        int ind = 4;
        foreach (int num in nums)
        {
            Console.WriteLine(num);
            rev_nums[ind] = num;
            ind --;
        }
        foreach (int r_num in rev_nums)
        {
            Console.WriteLine(r_num);
        }
    }
}