using System;
using System.Collections.Generic;

namespace Task1_telNumb
{
    public class telephoneNumber
    {
        public int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

        public string generateNumber()
        {
            string result = "8 (";


            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i].ToString();
            }
            result = result.Insert(6, ") ");
            result = result.Insert(11, " ");
            result = result.Insert(14, "-");
            return result;

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            telephoneNumber TelNum = new telephoneNumber();
            Console.WriteLine(TelNum.generateNumber());
        }
    }
}
