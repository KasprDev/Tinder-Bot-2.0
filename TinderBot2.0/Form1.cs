using Newtonsoft.Json;

namespace TinderBot2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Invoker.LoginForm = this;
        }

        private async void btnInitialize_Click(object sender, EventArgs e)
        {
            ProxyType proxy = null;

            if (!string.IsNullOrWhiteSpace(txtProxyIp.Text))
            {
                proxy = new ProxyType()
                {
                    Ip = txtProxyIp.Text,
                    Port = Convert.ToInt32(txtProxyPort.Text),
                    Username = txtProxyUser.Text,
                    Password = txtProxyPass.Text
                };
            }

            var tinder = new Tinder(txtAuthToken.Text, proxy);
            var resp = await tinder.GetUser();

            if (resp?.Name == null)
            {
                MessageBox.Show(
                    "Unable to login to your Tinder account with the provided xAuthToken. It may have expired, please login again.",
                    "Tinder Suite");
                return;
            }

            // Save the xAuthToken for faster account logins.
            if (checkStayLoggedIn.Checked)
                Settings.SaveAccountInstance(txtAuthToken.Text);

            Tinder.RegisterInstance(tinder);
            this.Hide();
            new MainForm().Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //await new Tinder(null).Login("14105999868");

            Settings.ValidateFolders();

            var files = Directory.GetFiles(Settings.AccountPath);

            if (files.Length <= 0) return;

            var tinder = new Tinder(await File.ReadAllTextAsync(files.First()), null);
            var resp = await tinder.GetUser();

            if (resp?.Name == null)
            {
                File.Delete(Path.Combine(Settings.AccountPath, $"{tinder._authToken}.txt"));
                MessageBox.Show(
                    "Unable to login to your Tinder account with the provided xAuthToken. It may have expired, please login again.",
                    "Tinder Suite");
                return;
            }

            Tinder.RegisterInstance(tinder);
            this.Hide();
            new MainForm().Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}