namespace PredictorUI
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            btnSimulate = new Button();
            btnMatchHistory = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Highlight;
            btnLogin.Location = new Point(115, 103);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(209, 59);
            btnLogin.TabIndex = 0;
            btnLogin.Tag = "hello";
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Highlight;
            btnRegister.Location = new Point(414, 103);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(209, 59);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSimulate
            // 
            btnSimulate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimulate.ForeColor = SystemColors.Highlight;
            btnSimulate.Location = new Point(115, 242);
            btnSimulate.Name = "btnSimulate";
            btnSimulate.Size = new Size(209, 59);
            btnSimulate.TabIndex = 2;
            btnSimulate.Text = "Simulate Match";
            btnSimulate.UseVisualStyleBackColor = true;
            btnSimulate.Click += btnSimulate_Click;
            // 
            // btnMatchHistory
            // 
            btnMatchHistory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMatchHistory.ForeColor = SystemColors.Highlight;
            btnMatchHistory.Location = new Point(414, 242);
            btnMatchHistory.Name = "btnMatchHistory";
            btnMatchHistory.Size = new Size(209, 59);
            btnMatchHistory.TabIndex = 3;
            btnMatchHistory.Text = "Show Match History";
            btnMatchHistory.UseVisualStyleBackColor = true;
            btnMatchHistory.Click += btnMatchHistory_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = SystemColors.Highlight;
            btnHelp.Location = new Point(683, 12);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(105, 45);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Help?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 412);
            Controls.Add(btnHelp);
            Controls.Add(btnMatchHistory);
            Controls.Add(btnSimulate);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Welcome";
            FormClosed += WelcomeForm_FormClosed;
            VisibleChanged += WelcomeForm_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnSimulate;
        private Button btnMatchHistory;
        private Button btnHelp;
    }
}