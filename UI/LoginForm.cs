using PredictorUI.Common;

namespace PredictorUI
{
    public partial class LoginForm : Form
    {
        private readonly IDataService dataService;
        public LoginForm(IDataService dataService)
        {
            InitializeComponent();
            this.dataService = dataService;
            lbl_PasswordError.Text = lbl_UsernameError.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
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
                MessageBox.Show(result.ToString());
            }
        }

        private bool ValidateInputs()
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
            if (chk_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }
    }
}
