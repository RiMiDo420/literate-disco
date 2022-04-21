using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Polish_Calculation
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please input the problem");
                Console.WriteLine(Calculate(Console.ReadLine()));

            }
            


        }

        public static string Calculate(string input)
        {
            try
            {
                List<string> problem = input.Split().ToList();
                for (int i = 0; i < problem.Count; i++)
                {
                    switch (problem[i])
                    {
                        case "+":
                            problem[i] = (double.Parse(problem[i - 1]) + double.Parse(problem[i - 2])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "-":
                            problem[i] = (double.Parse(problem[i - 2]) - double.Parse(problem[i - 1])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "*":
                            problem[i] = (double.Parse(problem[i - 1]) * double.Parse(problem[i - 2])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "/":
                            problem[i] = (double.Parse(problem[i - 2]) / double.Parse(problem[i - 1])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "%":
                            problem[i] = (double.Parse(problem[i - 2]) % double.Parse(problem[i - 1])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "^":
                            problem[i] = Math.Pow(double.Parse(problem[i - 2]), double.Parse(problem[i - 1])).ToString();
                            problem.RemoveAt(i - 1);
                            problem.RemoveAt(i - 2);
                            i -= 2;
                            break;
                        case "!":
                            problem[i] = Factorial(double.Parse(problem[i - 1])).ToString();
                            problem.RemoveAt(i - 1);
                            i --;
                            break;
                        default:
                            break;
                    }

                }
                return problem[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                return "stupid";
            }
        }

        static double Factorial(double x) 
        {
            double result = 1;
            for(double i = x; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }

    }
}
