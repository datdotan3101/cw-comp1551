using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Models
{
    public class OpenEndedQuestion : Question
    {
        public List<string> AcceptableAnswers { get; set; }

        public OpenEndedQuestion(string text, List<string> acceptableAnswers)
            : base(text)
        {
            AcceptableAnswers = acceptableAnswers;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return AcceptableAnswers.Any(a =>
                string.Equals(a.Trim(), userAnswer.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public override string GetCorrectAnswer()
        {
            return AcceptableAnswers.FirstOrDefault() ?? "";
        }
        public string GetHint()
        {
            var correct = GetCorrectAnswer();
            if (string.IsNullOrWhiteSpace(correct)) return "";
            return correct.Substring(0, 1).ToUpper() + new string('_', correct.Length - 1);
        }
    }
}
