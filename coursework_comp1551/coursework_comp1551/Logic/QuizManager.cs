using coursework_comp1551.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_comp1551.Logic
{
    public class QuizManager
    {
        private List<Question> questions = new List<Question>();
        private int currentIndex = 0;
        private int correctCount = 0;
        private DateTime startTime;

        public IReadOnlyList<Question> Questions => questions.AsReadOnly();

        public void AddQuestion(Question q)
        {
            questions.Add(q);
        }

        public void RemoveQuestion(Question q)
        {
            questions.Remove(q);
        }

        public void EditQuestion(int index, Question updatedQuestion)
        {
            if (index >= 0 && index < questions.Count)
                questions[index] = updatedQuestion;
        }

        public void ResetGame()
        {
            ShuffleQuestions();
            currentIndex = 0;
            correctCount = 0;
            startTime = DateTime.Now;
        }

        public Question GetNextQuestion()
        {
            if (currentIndex < questions.Count)
                return questions[currentIndex];
            return null;
        }

        public bool SubmitAnswer(string userAnswer)
        {
            if (currentIndex >= questions.Count) return false;

            var question = questions[currentIndex];
            bool isCorrect = question.CheckAnswer(userAnswer);
            if (isCorrect) correctCount++;
            currentIndex++;
            return isCorrect;
        }

        public int GetScore()
        {
            return correctCount;
        }

        public int GetTotalQuestions()
        {
            return questions.Count;
        }

        public TimeSpan GetTimeSpent()
        {
            return DateTime.Now - startTime;
        }

        private void ShuffleQuestions()
        {
            Random rng = new Random();
            questions = questions.OrderBy(q => rng.Next()).ToList();
        }

        public void ClearAllQuestions()
        {
            questions.Clear();
        }
    }
}
