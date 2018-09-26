using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSolution;

namespace InterviewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter numerical sequence or string. Enter quit to exit: ");
                    var input = Console.ReadLine().Trim();
                    if (input.Equals("quit"))
                    {
                        break;
                    }
                    var listOfItems = input.Split(' ').Select(item => double.TryParse(item, out double n) ? n : (double?)null);

                    //To check if th input is a numerical sequence 
                    //otherwise it is a string input for next question
                    if (listOfItems.All(n => n.HasValue))
                    {
                        var questionOne = new QuestionOne(listOfItems.Select(n => n.Value).ToArray());
                        Console.WriteLine("Output");
                        Console.WriteLine($"Mean :{questionOne.GetMean().ToString("N2")}");
                        Console.WriteLine($"Median :{questionOne.GetMedian().ToString("N2")}");
                        Console.WriteLine($"Mode :{questionOne.GetMode()}");
                        Console.WriteLine($"Range :{questionOne.GetRange()}");
                    }
                    else
                    {
                        var questionTwo = new QuestionTwo(input);
                        Console.WriteLine("Output");
                        foreach (var pair in questionTwo.GetCount())
                        {
                            Console.WriteLine($"{pair.Key}:{pair.Value}");
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}-{exception.InnerException}");
            }
        }
    }
}
