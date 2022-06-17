using System;

namespace FibTest
{
    

    class Program
    {

        static int Fib(int mode, int value)
        {

            if (mode == 1)
            {
                int result = 0;
                if (value == 0)
                    return result = 0;
                else if (value == 1)
                {
                    return result = 1;
                }

                int prevNode = 0, nextNode = 1;


                for (int i = 2; i <= value; i++)
                {
                    result = nextNode + prevNode; // 1   2    3  5    8  13
                    prevNode = nextNode;  // 1  1  2  3   5  
                    nextNode = result;  // 1  2  3  5  8

                }

                return result;
            }

            else if (mode == 2)
            {
                if(value == 0)
                {
                    return 0;
                }

                int result = 0;
                int prevNode = 0, nextNode = 1, i = 1;

                do
                {                   
                    result = nextNode + prevNode; // 1   2    3  5    8  13   21
                    prevNode = nextNode;  // 1  1  2  3   5    8  13
                    nextNode = result;  // 1  2  3  5  8  13   21
                    ++i;
                }
                while (result < value);

                if (result > value) return -1;

                return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Fib(2, 0));
            Console.WriteLine(Program.Fib(2, 1));
            Console.WriteLine(Program.Fib(2, 2));
            Console.WriteLine(Program.Fib(2, 21));
            Console.WriteLine(Program.Fib(2, 22));
            Console.WriteLine(Program.Fib(2, 35));
            Console.WriteLine(Program.Fib(2, 34));
        }
    }
}
