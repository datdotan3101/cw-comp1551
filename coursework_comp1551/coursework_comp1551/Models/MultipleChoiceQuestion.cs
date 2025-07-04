using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> Options { get; set; } = new List<string>();
        public int CorrectOptionIndex { get; set; }

        public MultipleChoiceQuestion(string text, List<string> options, int correctIndex)
            : base(text)
        {
            Options = options;
            CorrectOptionIndex = correctIndex;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            
            if (int.TryParse(userAnswer, out int index))
                return index == CorrectOptionIndex;
            return false;
        }

        public override string GetCorrectAnswer()
        {
            return Options[CorrectOptionIndex];
        }
    }
}
