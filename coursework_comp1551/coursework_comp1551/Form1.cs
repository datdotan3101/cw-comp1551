// File: Form1.cs
using coursework_comp1551.Logic;
using coursework_comp1551.UI;
using System;
using System.Windows.Forms;

namespace coursework_comp1551
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnPlay.Click += (s, e) =>
            {
                var allQuestions = QuestionStorage.LoadAllQuestions();
                if (allQuestions == null || allQuestions.Count == 0)
                {
                    MessageBox.Show("❗Empty question.\nPlease enter your new question before you start!", "Annoucement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new GameForm().ShowDialog();
            };

            btnManage.Click += (s, e) =>
            {
                new QuestionManagerForm().ShowDialog();
            };
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
