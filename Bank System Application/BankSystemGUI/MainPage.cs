namespace BankSystemGUI
{
    public partial class MainPage : Form
    {
        Thread th;
        public MainPage()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            /*
            RegisterationForm registeration = new RegisterationForm();
            registeration.Show();
            Visible = false;
            */
            th = new Thread(openRegistrationForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }
        private void openRegistrationForm()
        {
            Application.Run(new RegisterationForm());
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit Application", "Exit App", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}