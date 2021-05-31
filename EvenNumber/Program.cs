using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIsEvenUsingSwitch(10.1f);
        }

        public static void CheckIsEvenUsingIfElse(float num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is not even");
            }
        }

        public static void CheckIsEvenUsingTernaryOperator(float num)
        {
            Console.WriteLine(num % 2 == 0 ? "The number is even" : "The number is not even");
        }

        public static void CheckIsEvenUsingSwitch(float num)
        {
            var remaining = num % 2;
            switch (remaining)
            {
                case 0:
                    Console.WriteLine("The number is even");
                    break;
                default:
                    Console.WriteLine("The number is not even");
                    break;
            }
        }
    }
}
