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
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(115, 103);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 93);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(411, 103);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 93);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSimulate
            // 
            btnSimulate.Location = new Point(115, 253);
            btnSimulate.Name = "btnSimulate";
            btnSimulate.Size = new Size(161, 88);
            btnSimulate.TabIndex = 2;
            btnSimulate.Text = "Simulate Match";
            btnSimulate.UseVisualStyleBackColor = true;
            btnSimulate.Click += btnSimulate_Click;
            // 
            // btnMatchHistory
            // 
            btnMatchHistory.Location = new Point(414, 260);
            btnMatchHistory.Name = "btnMatchHistory";
            btnMatchHistory.Size = new Size(155, 81);
            btnMatchHistory.TabIndex = 3;
            btnMatchHistory.Text = "Show Match History";
            btnMatchHistory.UseVisualStyleBackColor = true;
            btnMatchHistory.Click += btnMatchHistory_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMatchHistory);
            Controls.Add(btnSimulate);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            FormClosed += WelcomeForm_FormClosed;
            VisibleChanged += WelcomeForm_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnSimulate;
        private Button btnMatchHistory;
    }
}