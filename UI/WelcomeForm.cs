using PredictorUI.Models;

namespace PredictorUI
{
    public partial class WelcomeForm : Form
    {
        private SharedData sharedData { get; set; }
        public WelcomeForm(SharedData? sharedData = null)
        {
            this.sharedData = sharedData ?? new SharedData
            {
                WelcomeForm = this
            };
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm(sharedData);
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm(sharedData);
            registerForm.Show();

        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            btnLogin.Visible = btnRegister.Visible = !sharedData.UserLoggedIn;
            btnSimulate.Visible = btnMatchHistory.Visible = sharedData.UserLoggedIn;
        }

        private void btnMatchHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mhistForm = new MatchHistoryForm(sharedData);
            mhistForm.Show();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var simForm = new SimulationForm(sharedData);
            simForm.Show();
        }

        private void WelcomeForm_Shown(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_VisibleChanged(object sender, EventArgs e)
        {
            btnLogin.Visible = btnRegister.Visible = !sharedData.UserLoggedIn;
            btnSimulate.Visible = btnMatchHistory.Visible = sharedData.UserLoggedIn;
        }
     
    }
}
