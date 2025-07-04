// File: QuestionManagerForm.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using coursework_comp1551.Logic;
using coursework_comp1551.Models;

namespace coursework_comp1551.UI
{
    public partial class QuestionManagerForm : Form
    {
        private List<Question> currentQuestions = new List<Question>();

        public QuestionManagerForm()
        {
            InitializeComponent();
            LoadQuestions();

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void LoadQuestions()
        {
            currentQuestions = QuestionStorage.LoadAllQuestions();
            lstQuestions.Items.Clear();
            foreach (var q in currentQuestions)
            {
                lstQuestions.Items.Add(Truncate(q.Text, 80));
            }
        }

        private string Truncate(string text, int max)
        {
            if (string.IsNullOrWhiteSpace(text)) return "(Empty question)";
            return text.Length > max ? text.Substring(0, max) + "..." : text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditQuestionForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                QuestionStorage.SaveQuestion(addForm.NewQuestion);
                LoadQuestions();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = lstQuestions.SelectedIndex;
            if (index >= 0 && index < currentQuestions.Count)
            {
                var editForm = new AddEditQuestionForm(currentQuestions[index]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    QuestionStorage.ReplaceQuestion(index, editForm.NewQuestion);
                    LoadQuestions();
                }
            }
            else
            {
                MessageBox.Show("Please choose a question to edit");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = lstQuestions.SelectedIndex;
            if (index >= 0 && index < currentQuestions.Count)
            {
                var confirm = MessageBox.Show("Do you want to delete this question?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    QuestionStorage.DeleteQuestion(index);
                    LoadQuestions();
                }
            }
            else
            {
                MessageBox.Show("Please choose a question to delete.");
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
