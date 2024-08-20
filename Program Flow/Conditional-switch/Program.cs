using System;

namespace ConditionalOps
{
    class Program
    {
        public static void Main(string[] args)
        {
            int theVal = 60;

            // The switch statement
            switch (theVal)
            {
                case 50:
                    Console.WriteLine("The val is 50");
                    break;
                case 51:
                    Console.WriteLine("The val is 51");
                    break;
                case 52:
                    Console.WriteLine("The val is 52");
                    break;
                case 53:
                    Console.WriteLine("The val is 53");
                    break;
                case 54:
                    Console.WriteLine("The val is 54");
                    break;
                case 55:
                case 56:
                case 57:
                case 58:
                    Console.WriteLine("The val is between 55 to 58");
                    break;
                default:
                    Console.WriteLine("The value is something else");
                    break;
            }
        }
    }
}