using PredictorUI.Common;
using PredictorUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PredictorUI
{
    public partial class RegisterForm : Form
    {
        private readonly DataService dataService;
        private SharedData sharedData;
        private bool registrationSuccesful = false;
        public RegisterForm(SharedData sharedData)
        {
            InitializeComponent();
            this.dataService = new DataService();
            lbl_UserNameError.Text = lbl_PasswordError.Text = lbl_EmailAddressError.Text = lbl_ConfirmPasswordError.Text = string.Empty;
            this.sharedData = sharedData;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
                //If all inputs are valid
            {
                var result = dataService.RegisterNewUser(txt_UserName.Text, txt_Password.Text, txt_EmailAddress.Text);
                //executing query
                switch (result)
                {
                    case ResponseTypes.RegistrationResponseTypes.DuplicateUsername:
                        MessageBox.Show("Username already in use");
                        break;
                    case ResponseTypes.RegistrationResponseTypes.Success:
                        MessageBox.Show("Successfully registered, please login to continue");
                        var loginForm = new LoginForm(sharedData);
                        registrationSuccesful = true;
                        this.Close();
                        loginForm.Show();
                        break;
                    case ResponseTypes.RegistrationResponseTypes.Failed:
                        MessageBox.Show("Registration failed");
                        break;
                    case ResponseTypes.RegistrationResponseTypes.DuplicateEmail:
                        MessageBox.Show("Email already in use");
                        break;

                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
            //Clears values in all fields and error labels. 
            //Unchecks checkbox and rehides password as *
        {
            dataService.AuthenticateUser("", "");
            txt_UserName.Clear();
            txt_Password.Clear();
            txt_EmailAddress.Clear();
            txt_ConfirmPassword.Clear();
            lbl_UserNameError.Text = lbl_PasswordError.Text = lbl_EmailAddressError.Text = lbl_ConfirmPasswordError.Text = string.Empty;
            chk_ShowPassword.Checked = false;
            txt_Password.PasswordChar = '*';
        }

        private bool ValidateInputs()
            //Makes sure all inputs are in the right format, applying presence and format check
        {
            bool allValid = true;
            lbl_UserNameError.Text = lbl_PasswordError.Text = lbl_EmailAddressError.Text = lbl_ConfirmPasswordError.Text = string.Empty;

            //Username check
            if (!IsValidInput(txt_UserName.Text))
            {
                lbl_UserNameError.Text = "Username is required";
                allValid = false;
            }

            //Email check
            if (!IsValidInput(txt_EmailAddress.Text))
            {
                lbl_EmailAddressError.Text = "Email address is required";
                allValid = false;
            }
            else
            {
                //Applying regex to check if email is in format john@gmail.com
                string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txt_EmailAddress.Text, patternEmail, RegexOptions.IgnoreCase))
                {
                    lbl_EmailAddressError.Text = "Invalid email address";
                    allValid = false;
                };

            }

            //Password check
            if (!IsValidInput(txt_Password.Text))
            {
                lbl_PasswordError.Text = "Password is required";
                allValid = false;
            }
            else
            {
                //Applying regex to check if string contains min 8 characters, 1 number and 1 special character
                string patternPassword = @"^(?=.*\d)(?=.*[!@#$%^&*])(?=.*[a-zA-Z]).{8,15}$";
                if (!Regex.IsMatch(txt_Password.Text, patternPassword, RegexOptions.IgnoreCase))
                {
                    lbl_PasswordError.Text = "Password too weak";
                    allValid = false;
                }

                //Checking password = Confirm Password
                else if (txt_Password.Text != txt_ConfirmPassword.Text)
                {
                    lbl_ConfirmPasswordError.Text = "Password does not match";
                    allValid = false;
                }

            }
            return allValid;
        }

        private bool IsValidInput(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            return input.Trim().Length > 0;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void chk_ShowPasword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!registrationSuccesful)sharedData.WelcomeForm.Show();
        }
    }
}
