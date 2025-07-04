// File: QuestionManagerForm.Designer.cs
namespace coursework_comp1551.UI
{
    partial class QuestionManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstQuestions = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lstQuestions
            // 
            lstQuestions.Location = new Point(20, 20);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(540, 244);
            lstQuestions.TabIndex = 0;
            lstQuestions.SelectedIndexChanged += lstQuestions_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Location = new Point(20, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 57);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Create";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(200, 290);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 57);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "✏️ Edit";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(385, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 57);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "🗑️ Delete";
            // 
            // QuestionManagerForm
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(lstQuestions);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "QuestionManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🛠️ Manage question";
            ResumeLayout(false);
        }
    }
}
