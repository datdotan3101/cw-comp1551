using System.Drawing;
using System.Windows.Forms;

namespace coursework_comp1551.UI
{
    partial class AddEditQuestionForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cboType;
        private TextBox txtQuestion;
        private TextBox txtOption0;
        private TextBox txtOption1;
        private TextBox txtOption2;
        private TextBox txtOption3;
        private RadioButton rbOption0;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private TextBox txtOpenAnswer;
        private RadioButton rbTrue;
        private RadioButton rbFalse;
        private Button btnSave;
        private Label lblType;
        private Label lblQ;
        private Label lblAnswer;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cboType = new ComboBox();
            txtQuestion = new TextBox();
            txtOption0 = new TextBox();
            txtOption1 = new TextBox();
            txtOption2 = new TextBox();
            txtOption3 = new TextBox();
            rbOption0 = new RadioButton();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            txtOpenAnswer = new TextBox();
            rbTrue = new RadioButton();
            rbFalse = new RadioButton();
            btnSave = new Button();
            lblType = new Label();
            lblQ = new Label();
            lblAnswer = new Label();
            SuspendLayout();
            // 
            // cboType
            // 
            cboType.Cursor = Cursors.Hand;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Items.AddRange(new object[] { "Multiple Choice", "Open Ended", "True / False" });
            cboType.Location = new Point(120, 20);
            cboType.Name = "cboType";
            cboType.Size = new Size(300, 28);
            cboType.TabIndex = 1;
            cboType.SelectedIndexChanged += CboType_SelectedIndexChanged;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(20, 87);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(551, 27);
            txtQuestion.TabIndex = 3;
            // 
            // txtOption0
            // 
            txtOption0.Location = new Point(50, 127);
            txtOption0.Name = "txtOption0";
            txtOption0.Size = new Size(480, 27);
            txtOption0.TabIndex = 5;
            // 
            // txtOption1
            // 
            txtOption1.Location = new Point(50, 170);
            txtOption1.Name = "txtOption1";
            txtOption1.Size = new Size(480, 27);
            txtOption1.TabIndex = 7;
            // 
            // txtOption2
            // 
            txtOption2.Location = new Point(50, 210);
            txtOption2.Name = "txtOption2";
            txtOption2.Size = new Size(480, 27);
            txtOption2.TabIndex = 9;
            // 
            // txtOption3
            // 
            txtOption3.Location = new Point(50, 250);
            txtOption3.Name = "txtOption3";
            txtOption3.Size = new Size(480, 27);
            txtOption3.TabIndex = 11;
            // 
            // rbOption0
            // 
            rbOption0.Location = new Point(20, 130);
            rbOption0.Name = "rbOption0";
            rbOption0.Size = new Size(32, 24);
            rbOption0.TabIndex = 4;
            // 
            // rbOption1
            // 
            rbOption1.Location = new Point(20, 170);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(24, 24);
            rbOption1.TabIndex = 6;
            // 
            // rbOption2
            // 
            rbOption2.Location = new Point(20, 210);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(32, 24);
            rbOption2.TabIndex = 8;
            // 
            // rbOption3
            // 
            rbOption3.Location = new Point(20, 250);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(32, 24);
            rbOption3.TabIndex = 10;
            // 
            // txtOpenAnswer
            // 
            txtOpenAnswer.Location = new Point(120, 122);
            txtOpenAnswer.Name = "txtOpenAnswer";
            txtOpenAnswer.Size = new Size(218, 27);
            txtOpenAnswer.TabIndex = 12;
            txtOpenAnswer.Visible = false;
            // 
            // rbTrue
            // 
            rbTrue.Location = new Point(20, 120);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(100, 25);
            rbTrue.TabIndex = 13;
            rbTrue.Text = "True";
            // 
            // rbFalse
            // 
            rbFalse.Location = new Point(130, 120);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(100, 25);
            rbFalse.TabIndex = 14;
            rbFalse.Text = "False";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(218, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 15;
            btnSave.Text = "💾 Save";
            // 
            // lblType
            // 
            lblType.ForeColor = SystemColors.ActiveCaptionText;
            lblType.Location = new Point(20, 20);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 25);
            lblType.TabIndex = 0;
            lblType.Text = "Type of questions:";
            // 
            // lblQ
            // 
            lblQ.Location = new Point(20, 60);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(100, 25);
            lblQ.TabIndex = 2;
            lblQ.Text = "Question:";
            // 
            // lblAnswer
            // 
            lblAnswer.Location = new Point(12, 122);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(102, 25);
            lblAnswer.TabIndex = 0;
            lblAnswer.Text = "Answer:";
            lblAnswer.Visible = false;
            // 
            // AddEditQuestionForm
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(lblAnswer);
            Controls.Add(lblType);
            Controls.Add(cboType);
            Controls.Add(lblQ);
            Controls.Add(txtQuestion);
            Controls.Add(rbOption0);
            Controls.Add(txtOption0);
            Controls.Add(rbOption1);
            Controls.Add(txtOption1);
            Controls.Add(rbOption2);
            Controls.Add(txtOption2);
            Controls.Add(rbOption3);
            Controls.Add(txtOption3);
            Controls.Add(txtOpenAnswer);
            Controls.Add(rbTrue);
            Controls.Add(rbFalse);
            Controls.Add(btnSave);
            Name = "AddEditQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit question";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
