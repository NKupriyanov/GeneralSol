using System;

namespace Home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
        }


        public static void Task1()
        {
            Console.Write("Enter operand1: ");
            string operanD1 = Console.ReadLine();
            int operand1 = Int32.Parse(operanD1);

            Console.Write("Enter operand2: ");
            string operanD2 = Console.ReadLine();
            int operand2 = Int32.Parse(operanD2);

            Console.Write("Enter the sing of operation: ");
            string sing = Console.ReadLine();
                        
            switch (sing)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    if (operand2 == 0);
                    {
                        Console.WriteLine($"{operand1} {sing} {operand2} = Division by zero is not allowed");
                        return;
                    }
                    {
                        Console.WriteLine(operand1 / operand2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered an invalid character");
                        return;
                    }
            }
            Console.WriteLine();
        }


        public static void Task2()
        {
            Console.WriteLine("Enter namber");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The number is not in any range. < 0");
            }
            else if (number < 15)
            {
                Console.WriteLine("Range [0-14]");
            }
            else if (number < 36)
            {
                Console.WriteLine("Range [15-35]");
            }
            else if (number < 51)
            {
                Console.WriteLine("Range [36-50]");
            }
            else if (number < 101)
            {
                Console.WriteLine("Range [51-100]");
            }
            else
            {
                Console.WriteLine("The number is not in any range. > 100");
            }
        }


        public static void Task3()
        {
            Console.WriteLine("Enter word:");

            string rWord = Console.ReadLine();

            switch (rWord)
            {
                case "погода": Console.WriteLine("weather"); break;
                case "дождь": Console.WriteLine("rain"); break;
                case "вьюга": Console.WriteLine("snowstorm"); break;
                case "туман": Console.WriteLine("fog"); break;
                case "облачно": Console.WriteLine("cloud"); break;
                case "снег": Console.WriteLine("snow"); break;
                case "град": Console.WriteLine("hail"); break;
                case "тепло": Console.WriteLine("warm"); break;
                case "холодно": Console.WriteLine("cold"); break;
                case "гроза": Console.WriteLine("thunderstorm"); break;
                default:
                    Console.WriteLine("This word is absent in distionary");
                    break;
            }
        }

        public static void Task4()
        {
            int a;
            Console.WriteLine("Enter number:");
            a = Console.Read();

            if (a % 2 == 1)
            {
                Console.WriteLine("Not an even number");

            }
            else
            {
                Console.WriteLine("An even number");
            }
        }
    }
}