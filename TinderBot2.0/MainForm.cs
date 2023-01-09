using TinderBot2._0.Objects;

namespace TinderBot2._0
{
    public partial class MainForm : Form
    {
        public TinderUser? User { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var user = await Tinder.Instances.First().GetUser();

            if (user == null)
            {
                MessageBox.Show("Unable to login to the specified account.", "Tinder Suite");
            }
            else
            {
                User = user;
            }

            Text = $"Tinder Suite - {user?.Name}";
            pictureUser.LoadAsync(user?.Photos.First().Url);
            labelName.Text = user?.Name;
            lblBio.Text = user?.Bio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void autoLikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutoLiker().Show();
        }
    }
}
