// File: Form1.Designer.cs
namespace coursework_comp1551
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnManage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnPlay = new Button();
            btnManage = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(186, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(365, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🗺️ Geography Quiz";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(0, 192, 0);
            btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(267, 114);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(200, 61);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Start";
            btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.Location = new Point(267, 191);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(200, 40);
            btnManage.TabIndex = 2;
            btnManage.Text = "Manage";
            btnManage.Click += btnManage_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(738, 352);
            Controls.Add(lblTitle);
            Controls.Add(btnPlay);
            Controls.Add(btnManage);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\U0001f9e0 Geography Quiz";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
