using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Verilmiş a,b,c ədədləri üzərindən ən kiçiyini tapan proqram

            int a = 10;
            int b = 20;
            int c = 30;

            if (a <= b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            //- Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(max);

            //- Verilmiş ədədlər siyahısındaki 3-ə bölünən ədədlərin ədədi ortaslnl (ortalamasını) tapan proqram

            int[] nums = { 1, 3, 5, 7, 9, 11, 12 };
            int avg = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    avg += nums[i];
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("3-e bolunen eded yoxdur");
            }
            else
            {
                Console.WriteLine(avg / count);
            }

            // - Verilmiş ədədlər siyahısında 3 rəqəmli ədəd olub olmadığını tapan proqram

            int[] number = { 10, 30, 40, 55, 34, 23, 507 };
            bool is3Digits = false;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= 100 && number[i] <= 999)
                {
                    is3Digits= true;
                    break;
                }
            }

            if (is3Digits)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
