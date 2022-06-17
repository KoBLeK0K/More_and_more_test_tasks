using System;
using System.Globalization;

namespace ParseString
{
    class Program
    {
        static float[] FindDiapazone(string value)
        {
            float[] result = new float[2];
            string firstValue = " ", secondValue = " ";
            char[] arr;
            bool isFilledFirst = false, isFilledSecond = false;

            arr = value.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                string temp = "";

                while(char.IsDigit(arr[i]) || arr[i] == ',' && char.IsDigit(arr[i-1]) || arr[i] == '-' && char.IsDigit(arr[i + 1]) && char.IsDigit(arr[i-1]))
                {
                    temp += arr[i];
                    ++i;
                    if(i == arr.Length)
                    {
                        break;
                    }
                }

                if (!isFilledFirst && temp != "")
                {
                    firstValue = temp;
                    isFilledFirst = true;
                }
                else if (!isFilledSecond && temp != "")
                {
                    secondValue = temp;
                    isFilledSecond = true;
                    break;
                }

                
            }
            if(isFilledSecond)
            {
                result[0] = Math.Min(float.Parse(firstValue), float.Parse(secondValue));
                result[1] = Math.Max(float.Parse(firstValue), float.Parse(secondValue));
            }
            else
            {
                result[0] = float.NaN;
                result[1] = float.Parse(firstValue);
            }
            

            Console.WriteLine(result[0].ToString());
            Console.WriteLine(result[1].ToString());
            return result;
        }
        static void Main(string[] args)
        {
            string test = "om 7,4 to 463";
            string test2 = "vfwe,sdfhe -32,2";

            FindDiapazone(test2);

            
        }
    }
}
