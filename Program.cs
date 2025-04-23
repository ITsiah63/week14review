using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal class Program
    {
        static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        static double subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input first number?");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input second number?");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input a number to select operation");
                Console.WriteLine("1 for addition");
                Console.WriteLine("2 for subtraction");
                Console.WriteLine("3 for multiplaction");
                Console.WriteLine("4 for division");
                Console.WriteLine("Other for exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Result: "+ Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + subtraction(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + Multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Result: " + Divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("bye");
                        return;
                }
            }

            Console.WriteLine("factorial of 3: "+factorial(3)); //factorial assignment

            //double[] assignments = { 60, 20, 30, 80 };
            //double avgAssignments = Average(assignments);
            //double[] midterm = { 60, 20, 30, 80 };
            //double avMidterm = Average(assignments);
            //double[] final = { 60, 20, 30, 80 };
            //double avgFinal = Average(assignments);
            //double[] finalGrade = CalculateFinalGrade(avgAssignments, avgMidterms avgFinal);
            //double avgAssignments = Average(assignments);

            for (int i = 0; i < 5; i++)
            {
                int dices[] = RollDice();

                Console.WriteLine("first number " + dices[0] + "second number " + dices[]);
            }
            


        }
        static double CelsiusToFahrenheit(double celsius)
        {
            return ((celsius * 9 /5) * 32);
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return ((fahrenheit -32) *(5/9));
        }

        //1=1
        //2=1*2=2
        //3=1*2*3=2=3
        static long factorial(int number)
        {
            long retval = 1;

            if (number <= 0)
            {
                retval = -1;

            }
            else
            {
                for (int i = 0; i <= number; i++)
                {
                    retval = retval * i; //retval*=i
                }
            }

            return retval;

        }

        static double Average(double[] grades)
        {
            double retVal = 0;
            double sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }
            retVal = sum/grades.Length;

            return retVal;
        }
        public static double CalculateFinalGrade(double assignments, double midterms, double finals)
        {
            double retVal = 0;

            retVal = 0.4 + assignments * 0.3 * midterms * 0.4 * finals;

            return retVal;
        }

        static int CountVowels(string input)
        {
            int retVal = 0;
            string vowels = "aeiou";

            foreach (char c in input.ToLower())
            {
                if (vowels.Contains(c))
                {
                    retVal++;
                }
            }
            return retVal;
        }

        static Random ran = new Random();
        public static int[] RollDice() //dice rolling
        {
            int[] retVal = new int[2];

            
            retVal[0] = ran.Next(0, 7);

            retVal[1] = ran.Next(0, 7);

            return retVal;
        }


        static Dictionary<string, int> votes = new Dictionary<string, int>();

        static void CastVote(string candidateName)
        {
            votes[candidateName]++;
        }

        static void DisplayResult()
        {
            foreach (var x in votes)
            {
                Console.WriteLine(x.Key + " has " + x.Value);
            }
        }

        static void ResetVotes()
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();
            foreach (var x in votes)
            {
                temp.Add(x.Key, 0);
            }
            votes = temp;
        }


    }
}
