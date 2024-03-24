namespace PredictorUI
{
    partial class LoginForm
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
            btn_Login = new Button();
            btn_Clear = new Button();
            lbl_UserName = new Label();
            lbl_Password = new Label();
            lbl_UsernameError = new Label();
            lbl_PasswordError = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            chk_ShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.Highlight;
            btn_Login.Location = new Point(145, 244);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(209, 59);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Clear.ForeColor = SystemColors.Highlight;
            btn_Clear.Location = new Point(379, 244);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(209, 59);
            btn_Clear.TabIndex = 1;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserName.Location = new Point(153, 90);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(69, 17);
            lbl_UserName.TabIndex = 2;
            lbl_UserName.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(153, 144);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(66, 17);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password";
            // 
            // lbl_UsernameError
            // 
            lbl_UsernameError.AutoSize = true;
            lbl_UsernameError.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UsernameError.ForeColor = Color.Red;
            lbl_UsernameError.Location = new Point(458, 93);
            lbl_UsernameError.Name = "lbl_UsernameError";
            lbl_UsernameError.Size = new Size(68, 17);
            lbl_UsernameError.TabIndex = 4;
            lbl_UsernameError.Text = "username";
            // 
            // lbl_PasswordError
            // 
            lbl_PasswordError.AutoSize = true;
            lbl_PasswordError.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PasswordError.ForeColor = Color.Red;
            lbl_PasswordError.Location = new Point(458, 149);
            lbl_PasswordError.Name = "lbl_PasswordError";
            lbl_PasswordError.Size = new Size(66, 17);
            lbl_PasswordError.TabIndex = 5;
            lbl_PasswordError.Text = "password";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(246, 90);
            txt_Username.MaxLength = 15;
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "sriv123";
            txt_Username.Size = new Size(206, 25);
            txt_Username.TabIndex = 6;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(246, 141);
            txt_Password.MaxLength = 15;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(206, 25);
            txt_Password.TabIndex = 7;
            // 
            // chk_ShowPassword
            // 
            chk_ShowPassword.AutoSize = true;
            chk_ShowPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_ShowPassword.Location = new Point(153, 187);
            chk_ShowPassword.Name = "chk_ShowPassword";
            chk_ShowPassword.Size = new Size(122, 21);
            chk_ShowPassword.TabIndex = 8;
            chk_ShowPassword.Text = "Show password";
            chk_ShowPassword.UseVisualStyleBackColor = true;
            chk_ShowPassword.CheckedChanged += chk_ShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(632, 374);
            Controls.Add(chk_ShowPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_PasswordError);
            Controls.Add(lbl_UsernameError);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_UserName);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Login);
            Font = new Font("Segoe UI", 9.75F);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Login";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button btn_Clear;
        private Label lbl_UserName;
        private Label lbl_Password;
        private Label lbl_UsernameError;
        private Label lbl_PasswordError;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private CheckBox chk_ShowPassword;
    }
}