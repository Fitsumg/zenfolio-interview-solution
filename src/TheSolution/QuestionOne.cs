using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolution
{
    public class QuestionOne : IQuestionOne
    {
        private double[] numbers;

        public QuestionOne(double[] numbers)
        {
            this.numbers = numbers;
        }

        public double GetMean()
        {
            if (numbers != null && numbers.Length != 0)
            {
                //Option 1: 
                //return numbers.Average();
                //Option 2: 
                //return numbers.Sum()/(double)numbers.Length;
                //Option 3
                //var sum=0;
                //foreach (var n in numbers)
                //{
                //    sum += n;
                //}
                //return sum / (float)numbers.Length;
                return numbers.Sum() / (double)numbers.Length;
            }
            return 0;
        }

        public double GetMedian()
        {
            if (numbers != null && numbers.Length != 0)
            {
                var length = numbers.Length;
                if (length == 1)
                {
                    return numbers[0];
                }
                Array.Sort(numbers);
                if (length%2 == 0)
                {
                    return (numbers[length/2- 1] + numbers[length/2]) / 2.0;
                }
                return numbers[length/2];
            }
            return 0;
        }

        public string GetMode()
        {
            IDictionary<double, int> uniqueNumbers = new Dictionary<double, int>();
            foreach (var n in numbers)
            {
                if (!uniqueNumbers.ContainsKey(n))
                {
                    uniqueNumbers.Add(n, 1);
                }
                else
                {
                    uniqueNumbers[n] = ++uniqueNumbers[n];
                }
            }
            var max=uniqueNumbers.Values.Max();
            if (max <= 1)
            {
                return "none";
            }
            var mode = uniqueNumbers
                        .Where(pair => pair.Value == max)
                        .Select(pair => pair.Key)
                        .ToArray();
            return string.Join(",",mode);
        }

        private double GetRange2()
        {
            double min = numbers[0], max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return max - min;
        }

        public double GetRange()
        {
            if (numbers != null && numbers.Length != 0)
            {
                //Option 1: 
                //return numbers.Max<double>() - numbers.Min<double>();
                return GetRange2();
            }
            return 0;
        }
    }
}
