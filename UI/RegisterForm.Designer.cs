namespace PredictorUI
{
    partial class RegisterForm
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
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            txt_EmailAddress = new TextBox();
            txt_ConfirmPassword = new TextBox();
            lbl_EmailAddress = new Label();
            label2 = new Label();
            lbl_Password = new Label();
            lbl_ConfirmPassword = new Label();
            lbl_UserName = new Label();
            btn_Register = new Button();
            btn_Clear = new Button();
            lbl_UserNameError = new Label();
            lbl_PasswordError = new Label();
            lbl_ConfirmPasswordError = new Label();
            lbl_EmailAddressError = new Label();
            chk_ShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 9.75F);
            txt_UserName.Location = new Point(238, 162);
            txt_UserName.MaxLength = 15;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.PlaceholderText = "sriv123";
            txt_UserName.Size = new Size(259, 25);
            txt_UserName.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 9.75F);
            txt_Password.Location = new Point(238, 204);
            txt_Password.MaxLength = 15;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.PlaceholderText = "min 8 char, 1 number and 1 symbol";
            txt_Password.Size = new Size(259, 25);
            txt_Password.TabIndex = 3;
            // 
            // txt_EmailAddress
            // 
            txt_EmailAddress.Font = new Font("Segoe UI", 9.75F);
            txt_EmailAddress.Location = new Point(238, 120);
            txt_EmailAddress.MaxLength = 50;
            txt_EmailAddress.Name = "txt_EmailAddress";
            txt_EmailAddress.PlaceholderText = "sri@gmail.com";
            txt_EmailAddress.Size = new Size(259, 25);
            txt_EmailAddress.TabIndex = 1;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            txt_ConfirmPassword.Location = new Point(238, 246);
            txt_ConfirmPassword.MaxLength = 15;
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.PasswordChar = '*';
            txt_ConfirmPassword.Size = new Size(259, 25);
            txt_ConfirmPassword.TabIndex = 4;
            // 
            // lbl_EmailAddress
            // 
            lbl_EmailAddress.AutoSize = true;
            lbl_EmailAddress.Font = new Font("Segoe UI", 9.75F);
            lbl_EmailAddress.Location = new Point(126, 120);
            lbl_EmailAddress.Name = "lbl_EmailAddress";
            lbl_EmailAddress.Size = new Size(90, 17);
            lbl_EmailAddress.TabIndex = 6;
            lbl_EmailAddress.Text = "Email address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(238, 196);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 7;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 9.75F);
            lbl_Password.Location = new Point(148, 204);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(64, 17);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password";
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            lbl_ConfirmPassword.Location = new Point(101, 246);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(114, 17);
            lbl_ConfirmPassword.TabIndex = 9;
            lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Segoe UI", 9.75F);
            lbl_UserName.Location = new Point(145, 162);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(67, 17);
            lbl_UserName.TabIndex = 10;
            lbl_UserName.Text = "Username";
            // 
            // btn_Register
            // 
            btn_Register.Font = new Font("Segoe UI", 9.75F);
            btn_Register.ForeColor = SystemColors.Highlight;
            btn_Register.Location = new Point(148, 315);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(209, 59);
            btn_Register.TabIndex = 5;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI", 9.75F);
            btn_Clear.ForeColor = SystemColors.Highlight;
            btn_Clear.Location = new Point(376, 315);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(209, 59);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_UserNameError
            // 
            lbl_UserNameError.AutoSize = true;
            lbl_UserNameError.Font = new Font("Segoe UI", 9.75F);
            lbl_UserNameError.ForeColor = Color.Red;
            lbl_UserNameError.Location = new Point(533, 170);
            lbl_UserNameError.Name = "lbl_UserNameError";
            lbl_UserNameError.Size = new Size(65, 17);
            lbl_UserNameError.TabIndex = 11;
            lbl_UserNameError.Text = "username";
            // 
            // lbl_PasswordError
            // 
            lbl_PasswordError.AutoSize = true;
            lbl_PasswordError.Font = new Font("Segoe UI", 9.75F);
            lbl_PasswordError.ForeColor = Color.Red;
            lbl_PasswordError.Location = new Point(533, 212);
            lbl_PasswordError.Name = "lbl_PasswordError";
            lbl_PasswordError.Size = new Size(65, 17);
            lbl_PasswordError.TabIndex = 13;
            lbl_PasswordError.Text = "password";
            // 
            // lbl_ConfirmPasswordError
            // 
            lbl_ConfirmPasswordError.AutoSize = true;
            lbl_ConfirmPasswordError.Font = new Font("Segoe UI", 9.75F);
            lbl_ConfirmPasswordError.ForeColor = Color.Red;
            lbl_ConfirmPasswordError.Location = new Point(533, 254);
            lbl_ConfirmPasswordError.Name = "lbl_ConfirmPasswordError";
            lbl_ConfirmPasswordError.Size = new Size(52, 17);
            lbl_ConfirmPasswordError.TabIndex = 14;
            lbl_ConfirmPasswordError.Text = "confirm";
            // 
            // lbl_EmailAddressError
            // 
            lbl_EmailAddressError.AutoSize = true;
            lbl_EmailAddressError.Font = new Font("Segoe UI", 9.75F);
            lbl_EmailAddressError.ForeColor = Color.Red;
            lbl_EmailAddressError.Location = new Point(533, 128);
            lbl_EmailAddressError.Name = "lbl_EmailAddressError";
            lbl_EmailAddressError.Size = new Size(39, 17);
            lbl_EmailAddressError.TabIndex = 15;
            lbl_EmailAddressError.Text = "email";
            // 
            // chk_ShowPassword
            // 
            chk_ShowPassword.AutoSize = true;
            chk_ShowPassword.Font = new Font("Segoe UI", 9.75F);
            chk_ShowPassword.Location = new Point(237, 279);
            chk_ShowPassword.Name = "chk_ShowPassword";
            chk_ShowPassword.Size = new Size(119, 21);
            chk_ShowPassword.TabIndex = 16;
            chk_ShowPassword.Text = "Show password";
            chk_ShowPassword.UseVisualStyleBackColor = true;
            chk_ShowPassword.CheckedChanged += chk_ShowPasword_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(770, 459);
            Controls.Add(chk_ShowPassword);
            Controls.Add(lbl_EmailAddressError);
            Controls.Add(lbl_ConfirmPasswordError);
            Controls.Add(lbl_PasswordError);
            Controls.Add(lbl_UserNameError);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Register);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_ConfirmPassword);
            Controls.Add(lbl_Password);
            Controls.Add(label2);
            Controls.Add(lbl_EmailAddress);
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(txt_EmailAddress);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Predictor - Register New Gamer";
            FormClosed += RegisterForm_FormClosed;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private TextBox txt_EmailAddress;
        private TextBox txt_ConfirmPassword;
        private Label lbl_EmailAddress;
        private Label label2;
        private Label lbl_Password;
        private Label lbl_ConfirmPassword;
        private Label lbl_UserName;
        private Button btn_Register;
        private Button btn_Clear;
        private Label lbl_UserNameError;
        private Label lbl_PasswordError;
        private Label lbl_ConfirmPasswordError;
        private Label lbl_EmailAddressError;
        private CheckBox chk_ShowPassword;
    }
}