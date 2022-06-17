using System;
using System.Collections.Generic;

namespace UniqueSymbols
{
    class CheckIfUnique
    { 
        public HashSet<char> uniqueSymbols(string innerString)
        {
            HashSet<char> setOfLetters = new HashSet<char>();

            innerString = innerString.ToLower();

            foreach (char a in innerString)
            {
                if (char.IsLetter(a))
                {
                    setOfLetters.Add(a);
                }
            }

            return setOfLetters;

           /* Здесь можно протестить значения в выводе
            
            string temp = "";

            foreach (char a in setOfLetters)
            {
                temp += a;
            }
            
            Console.WriteLine(temp);*/

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfUnique UniqueString = new CheckIfUnique();

            UniqueString.uniqueSymbols("h43el4351lo/+ 45WoRLd!");


        }
    }


}

