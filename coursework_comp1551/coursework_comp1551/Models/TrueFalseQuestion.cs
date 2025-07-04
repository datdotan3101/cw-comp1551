using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Models
{
    public class TrueFalseQuestion : Question
    {
        public bool IsTrue { get; set; }

        public TrueFalseQuestion(string text, bool isTrue)
            : base(text)
        {
            IsTrue = isTrue;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            // “true”, “false”
            string normalized = userAnswer.Trim().ToLower();
            if (normalized == "true" ) return IsTrue;
            if (normalized == "false" ) return !IsTrue;
            return false;
        }

        public override string GetCorrectAnswer()
        {
            return IsTrue ? "True" : "False";
        }
    }
}
