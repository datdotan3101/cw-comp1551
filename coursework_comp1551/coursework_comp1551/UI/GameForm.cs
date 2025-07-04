using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using coursework_comp1551.Models;
using coursework_comp1551.Logic;

namespace coursework_comp1551.UI
{
    public partial class GameForm : Form
    {
        private QuizManager quizManager;
        private Question currentQuestion;
        private Stopwatch stopwatch;
        private RadioButton[] rbOptions;
        public GameForm()
        {
            InitializeComponent();

            rbOptions = new[] { rbOption0, rbOption1, rbOption2, rbOption3 };

            quizManager = new QuizManager();
            stopwatch = new Stopwatch();

            StartGame();

            btnSubmit.Click += BtnSubmit_Click;
            btnSkip.Click += (s, e) => LoadNextQuestion();
            btnRestart.Click += BtnRestart_Click;
            btnQuit.Click += (s, e) => this.Close();
        }

        private void StartGame()
        {
            var questions = QuestionStorage.LoadAllQuestions();


            // Xoá đoạn thêm mặc định nếu đã có dữ liệu thật
            if (questions.Count == 0)
            {
                MessageBox.Show("No question. Please create your new questions");
                this.Close();
                return;
            }

            quizManager.ClearAllQuestions();
            foreach (var q in questions)
                quizManager.AddQuestion(q);

            quizManager.ResetGame();
            stopwatch.Restart();

            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            currentQuestion = quizManager.GetNextQuestion();
            if (currentQuestion == null)
            {
                ShowResult();
                return;
            }

            if (currentQuestion is OpenEndedQuestion openQ)
            {
                lblHint.Visible = true;
                lblHint.Text = $"Hint: {openQ.GetHint()}";
            }
            else
            {
                lblHint.Visible = false;
            }

            lblQuestion.Text = currentQuestion.Text;
            HideAllInputs();

            if (currentQuestion is MultipleChoiceQuestion mcq)
            {
                for (int i = 0; i < mcq.Options.Count; i++)
                {
                    rbOptions[i].Text = mcq.Options[i];
                    rbOptions[i].Visible = true;
                    rbOptions[i].Checked = false;
                }
            }
            else if (currentQuestion is OpenEndedQuestion)
            {
                txtAnswer.Text = "";
                txtAnswer.Visible = true;
            }
            else if (currentQuestion is TrueFalseQuestion)
            {
                rbTrue.Visible = true;
                rbFalse.Visible = true;
                rbTrue.Checked = false;
                rbFalse.Checked = false;
            }
        }

        private void HideAllInputs()
        {
            txtAnswer.Visible = false;
            foreach (var rb in rbOptions) rb.Visible = false;
            rbTrue.Visible = false;
            rbFalse.Visible = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string userAnswer = "";

            if (currentQuestion is MultipleChoiceQuestion)
            {
                for (int i = 0; i < rbOptions.Length; i++)
                {
                    if (rbOptions[i].Visible && rbOptions[i].Checked)
                        userAnswer = i.ToString();
                }
            }
            else if (currentQuestion is OpenEndedQuestion)
            {
                userAnswer = txtAnswer.Text.Trim();
            }
            else if (currentQuestion is TrueFalseQuestion)
            {
                if (rbTrue.Checked) userAnswer = "True";
                else if (rbFalse.Checked) userAnswer = "False";
            }

            bool isCorrect = quizManager.SubmitAnswer(userAnswer);

            lblResult.Visible = true;
            if (isCorrect)
            {
                lblResult.Text = "✅ Congratulation!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = $"❌ Oh no! Correct answer is: {currentQuestion.GetCorrectAnswer()}";
                lblResult.ForeColor = Color.Red;
            }

            // Delay 1.5s before to next question
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                LoadNextQuestion();
            };
            timer.Start();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ShowResult()
        {
            stopwatch.Stop();
            int score = quizManager.GetScore();
            int total = quizManager.GetTotalQuestions();
            double timeMinutes = stopwatch.Elapsed.TotalMinutes;

            var result = MessageBox.Show(
                $"🏁 Finished!\n✅ Correct: {score}/{total}\n⏱️ Timer: {timeMinutes:F2} minutes\n\nDo you start again?",
                "End",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                StartGame(); // restart game
            }
            else
            {
                this.Close(); // quit game
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblHint_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click_1(object sender, EventArgs e)
        {

        }
    }
}
