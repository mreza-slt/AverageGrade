using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app show your average grade...");
            bool exit = true;

            do
            {
                Console.Write("Please enter number of lesson: ");
                int numberOfScore = 0;
                while (!int.TryParse(Console.ReadLine(), out numberOfScore))
                {
                    Console.Write("Error..., Please enter number of lesson again: ");
                }
                double[] ScoreArray = new double[numberOfScore];
                int i = 0;
                while (i < numberOfScore)
                {
                    try
                    {
                        Console.Write($"Please enter score of lesson{i + 1}: ");
                        double score = Convert.ToDouble(Console.ReadLine());
                        if (score <= 20 && score >= 0)
                        {
                            ScoreArray[i] = score;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("The score should be between 0 and 20 .");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Wrong score format!!!");
                    }
                }

                double sum = 0;
                foreach (double grade in ScoreArray)
                {
                    sum += grade;
                }
                Console.WriteLine("Your score are :" + string.Join(",", ScoreArray));
                Console.WriteLine("Your average grade is : {0} ", sum / ScoreArray.Length);
                Console.WriteLine("---------------End---------------");
                Console.Write("if you want exit to program, type \"E\" , otherWise enter: ");

                var exitString = Console.ReadLine();
                if (!string.IsNullOrEmpty(exitString) && exitString.Trim().ToLower() == "e")
                    exit = true;
                else
                {
                    exit = false;
                    Console.Clear();
                    Console.WriteLine("---------------Start again---------------");
                }
            }
            while (!exit);
        }
    }
}
