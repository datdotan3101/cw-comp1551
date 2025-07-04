namespace coursework_comp1551.UI
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.RadioButton rbOption0;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblHint;
        private Label lblResult;  

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            rbOption0 = new RadioButton();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbTrue = new RadioButton();
            rbFalse = new RadioButton();
            btnSubmit = new Button();
            btnSkip = new Button();
            btnRestart = new Button();
            btnQuit = new Button();
            lblHint = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Navy;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = SystemColors.ControlLightLight;
            lblQuestion.Location = new Point(20, 18);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(668, 72);
            lblQuestion.TabIndex = 0;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(156, 127);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(364, 27);
            txtAnswer.TabIndex = 1;
            txtAnswer.Visible = false;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // rbOption0
            // 
            rbOption0.Location = new Point(20, 100);
            rbOption0.Name = "rbOption0";
            rbOption0.Size = new Size(500, 25);
            rbOption0.TabIndex = 2;
            rbOption0.Text = "Option 1";
            rbOption0.Visible = false;
            // 
            // rbOption1
            // 
            rbOption1.Location = new Point(20, 130);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(500, 25);
            rbOption1.TabIndex = 3;
            rbOption1.Text = "Option 2";
            rbOption1.Visible = false;
            // 
            // rbOption2
            // 
            rbOption2.Location = new Point(20, 160);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(500, 25);
            rbOption2.TabIndex = 4;
            rbOption2.Text = "Option 3";
            rbOption2.Visible = false;
            // 
            // rbOption3
            // 
            rbOption3.Location = new Point(20, 190);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(500, 25);
            rbOption3.TabIndex = 5;
            rbOption3.Text = "Option 4";
            rbOption3.Visible = false;
            // 
            // rbTrue
            // 
            rbTrue.Location = new Point(20, 100);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(100, 25);
            rbTrue.TabIndex = 6;
            rbTrue.Text = "True";
            rbTrue.Visible = false;
            // 
            // rbFalse
            // 
            rbFalse.Location = new Point(130, 100);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(100, 25);
            rbFalse.TabIndex = 7;
            rbFalse.Text = "False";
            rbFalse.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(106, 262);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "✔️ Submit";
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(224, 262);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(100, 30);
            btnSkip.TabIndex = 9;
            btnSkip.Text = "⏭️ Skip";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(334, 262);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(100, 30);
            btnRestart.TabIndex = 10;
            btnRestart.Text = "🔁 Retry";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(444, 262);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(100, 30);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "❌ Quit";
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblHint.Location = new Point(175, 218);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(279, 25);
            lblHint.TabIndex = 2;
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            lblHint.Visible = false;
            lblHint.Click += lblHint_Click;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(20, 190);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(500, 25);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "Option 4";
            radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(20, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(500, 25);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Option 3";
            radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(20, 130);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(500, 25);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Option 2";
            radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            radioButton4.Location = new Point(20, 100);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(500, 25);
            radioButton4.TabIndex = 2;
            radioButton4.Text = "Option 1";
            radioButton4.Visible = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.ForeColor = Color.Blue;
            lblResult.Location = new Point(245, 310);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(189, 30);
            lblResult.TabIndex = 0;
            lblResult.Visible = false;
            lblResult.Click += lblResult_Click_1;
            // 
            // GameForm
            // 
            ClientSize = new Size(700, 400);
            Controls.Add(lblResult);
            Controls.Add(lblHint);
            Controls.Add(lblQuestion);
            Controls.Add(txtAnswer);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(rbOption0);
            Controls.Add(radioButton2);
            Controls.Add(rbOption1);
            Controls.Add(radioButton1);
            Controls.Add(rbOption2);
            Controls.Add(rbOption3);
            Controls.Add(rbTrue);
            Controls.Add(rbFalse);
            Controls.Add(btnSubmit);
            Controls.Add(btnSkip);
            Controls.Add(btnRestart);
            Controls.Add(btnQuit);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🎮 Geography quiz";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
