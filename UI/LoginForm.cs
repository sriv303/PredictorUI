using PredictorUI.Common;
using PredictorUI.Models;

namespace PredictorUI
{
    public partial class LoginForm : Form
    {
        private readonly DataService dataService;
        private SharedData sharedData;
        public LoginForm(SharedData sharedData)
        {
            InitializeComponent();
            this.dataService = new DataService();
            lbl_PasswordError.Text = lbl_UsernameError.Text = "";
            this.sharedData = sharedData;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        //Clearing values inside every label and input box
        //Unchecking show password checkbox and resetting to show as **
        {
            txt_Username.Clear();
            txt_Password.Clear();
            lbl_PasswordError.Text = lbl_UsernameError.Text = "";
            chk_ShowPassword.Checked = false;
            txt_Password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                lbl_PasswordError.Text = lbl_UsernameError.Text = "";
                var result = dataService.AuthenticateUser(txt_Username.Text, txt_Password.Text);
                if (result == null)
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                {
                    if(sharedData==null) sharedData = new SharedData();
                    sharedData.User = result;

                    //redirection
                    this.Close();
                   // sharedData.WelcomeForm.sharedData = sharedData;
                    sharedData.WelcomeForm.Show();                    
                }
            }
        }

        private bool ValidateInputs()
        //Checking if inputs are empty or just spaces
        {
            var isValid = true;
            if (string.IsNullOrEmpty(txt_Username.Text.Trim()))
            {
                lbl_UsernameError.Text = "Username required";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                lbl_PasswordError.Text = "Password required";
                isValid = false;
            }

            return isValid;
        }



        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //If ShowPassword checked then show password, otherwise set back to *
            if (chk_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sharedData.WelcomeForm.Show();
        }       
    }
}
