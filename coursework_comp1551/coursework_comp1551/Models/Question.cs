using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Models
{
    public abstract class Question
    {
        public string Text { get; set; } // Question

        public Question(string text)
        {
            Text = text;
        }

        public abstract bool CheckAnswer(string userAnswer);
        public abstract string GetCorrectAnswer();
    }
}
