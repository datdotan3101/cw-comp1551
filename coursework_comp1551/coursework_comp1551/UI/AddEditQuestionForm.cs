using coursework_comp1551.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace coursework_comp1551.UI
{
    public partial class AddEditQuestionForm : Form
    {
        private Question editingQuestion;
        public Question NewQuestion { get; private set; }
        private TextBox[] txtOptions;
        private RadioButton[] rbOptionCorrect;

        public AddEditQuestionForm(Question questionToEdit = null)
        {
            editingQuestion = questionToEdit;
            InitializeComponent();

            // Array control to variable
            txtOptions = new[] { txtOption0, txtOption1, txtOption2, txtOption3 };
            rbOptionCorrect = new[] { rbOption0, rbOption1, rbOption2, rbOption3 };

            // Handle event
            cboType.SelectedIndexChanged += CboType_SelectedIndexChanged;
            btnSave.Click += BtnSave_Click;

            this.Text = questionToEdit == null ? "➕ Create question" : "✏️ Edit question";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 600;
            this.Height = 500;

            HideAllInputs();

            if (editingQuestion != null)
            {
                LoadEditingData();
            }
        }

        private void CboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboType.SelectedItem.ToString();

            bool isOpenEnded = selected.Contains("Open Ended");

            lblAnswer.Visible = isOpenEnded;
            txtOpenAnswer.Visible = isOpenEnded;

            // Visible/ Hide multiple question
            bool isMCQ = selected.Contains("Multiple Choice");
            rbOption0.Visible = rbOption1.Visible = rbOption2.Visible = rbOption3.Visible = isMCQ;
            txtOption0.Visible = txtOption1.Visible = txtOption2.Visible = txtOption3.Visible = isMCQ;

            // Visible / Hide true/ false
            bool isTrueFalse = selected.Contains("True / False");
            rbTrue.Visible = rbFalse.Visible = isTrueFalse;
        }

        private void HideAllInputs()
        {
            foreach (var t in txtOptions) t.Visible = false;
            foreach (var r in rbOptionCorrect) r.Visible = false;
            txtOpenAnswer.Visible = false;
            rbTrue.Visible = false;
            rbFalse.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string qText = txtQuestion.Text.Trim();
            if (string.IsNullOrWhiteSpace(qText))
            {
                MessageBox.Show("Please enter the content of question.");
                return;
            }

            switch (cboType.SelectedIndex)
            {
                case 0: // Multiple choice
                    List<string> options = new List<string>();
                    int correctIndex = -1;
                    for (int i = 0; i < 4; i++)
                    {
                        string opt = txtOptions[i].Text.Trim();
                        if (string.IsNullOrWhiteSpace(opt))
                        {
                            MessageBox.Show("Please enter 4 options.");
                            return;
                        }
                        options.Add(opt);
                        if (rbOptionCorrect[i].Checked) correctIndex = i;
                    }

                    if (correctIndex == -1)
                    {
                        MessageBox.Show("Please choose correct answer.");
                        return;
                    }

                    NewQuestion = new MultipleChoiceQuestion(qText, options, correctIndex);
                    break;

                case 1: // Open-ended question
                    string answer = txtOpenAnswer.Text.Trim();
                    if (string.IsNullOrWhiteSpace(answer))
                    {
                        MessageBox.Show("Please choose correct answer.");
                        return;
                    }
                    NewQuestion = new OpenEndedQuestion(qText, new List<string> { answer });
                    break;

                case 2: // True/ false
                    if (!rbTrue.Checked && !rbFalse.Checked)
                    {
                        MessageBox.Show("Please choose correct answer.");
                        return;
                    }
                    NewQuestion = new TrueFalseQuestion(qText, rbTrue.Checked);
                    break;

                default:
                    MessageBox.Show("Please choose type of questions");
                    return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadEditingData()
        {
            txtQuestion.Text = editingQuestion.Text;

            if (editingQuestion is MultipleChoiceQuestion mcq)
            {
                cboType.SelectedIndex = 0;
                for (int i = 0; i < 4; i++)
                {
                    txtOptions[i].Text = mcq.Options[i];
                    rbOptionCorrect[i].Checked = (i == mcq.CorrectOptionIndex);
                }
            }
            else if (editingQuestion is OpenEndedQuestion oeq)
            {
                cboType.SelectedIndex = 1;
                txtOpenAnswer.Text = oeq.AcceptableAnswers[0];
            }
            else if (editingQuestion is TrueFalseQuestion tfq)
            {
                cboType.SelectedIndex = 2;
                rbTrue.Checked = tfq.IsTrue;
                rbFalse.Checked = !tfq.IsTrue;
            }
        }

    }
}
