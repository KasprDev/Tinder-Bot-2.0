namespace TinderBot2._0.Licensing
{
    public partial class ActivateLicense : Form
    {
        public ActivateLicense()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var l = new TinderBot2._0.Licensing.Licensing();

            var result = await l.RegisterLicense(txtLicense.Text);

            if (result)
            {
                File.WriteAllText("license.lic", txtLicense.Text);
                Application.Restart();
            }

            button1.Enabled = true;
        }

        private void ActivateLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
