using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolution
{
    public class QuestionTwo : IQuestionTwo
    {
        private string input;

        public QuestionTwo(string input)
        {
            this.input = input;
        }

        public IDictionary<char,int> GetCount()
        {
            IDictionary<char, int> charWithCountOfOccurrance = new SortedDictionary<char, int>();
            var inputCharacters = input.Where(character=>char.IsLetterOrDigit(character)).ToArray();
            foreach (var character in inputCharacters)
            {
                if (!charWithCountOfOccurrance.ContainsKey(character))
                {
                    charWithCountOfOccurrance.Add(character, 1);
                }
                else
                {
                    charWithCountOfOccurrance[character] = ++charWithCountOfOccurrance[character];
                }
            }
            return charWithCountOfOccurrance;
        }
    }
}
