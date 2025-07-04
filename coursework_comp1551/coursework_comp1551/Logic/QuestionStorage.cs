using coursework_comp1551.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Logic
{
    public static class QuestionStorage
    {
        private static List<Question> _questions = new List<Question>();

        public static List<Question> LoadAllQuestions()
        {
            return new List<Question>(_questions);
        }

        public static void SaveQuestion(Question q)
        {
            _questions.Add(q);
        }

        public static void ReplaceQuestion(int index, Question q)
        {
            if (index >= 0 && index < _questions.Count)
                _questions[index] = q;
        }

        public static void DeleteQuestion(int index)
        {
            if (index >= 0 && index < _questions.Count)
                _questions.RemoveAt(index);
        }

        public static void ClearAll()
        {
            _questions.Clear();
        }
    }
}
