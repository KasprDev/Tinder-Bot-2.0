using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderBot2._0
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();
        }

        private void btnSelectMass_Click(object sender, EventArgs e)
        {
            using var o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtMass.Text = o.FileName;
            }
        }

        private async void btnMassMessage_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtMass.Text))
            {
                MessageBox.Show(
                    "Please enter a valid file to pull messages from. This needs to be 1 message per line.",
                    "TinderSuite");
                return;
            }

            var matches = await Tinder.Instances.First().GetMatches();

            btnMassMessage.Text = $"Messaging {matches.Data.Matches.Count} users.";
            btnMassMessage.Enabled = false;

            var r = new Random();
            var fileData = await File.ReadAllLinesAsync(txtMass.Text);

            foreach (var user in matches.Data.Matches)
            {
                var delay = r.Next(Convert.ToInt32(massDelay1.Value), Convert.ToInt32(massDelay1.Value));

                await Tinder.Instances.First().SendMessage(user.Id, fileData[r.Next(fileData.Length)]);
                await Task.Delay(TimeSpan.FromSeconds(delay));
            }

            MessageBox.Show($"Messages successfully sent to all {matches.Data.Matches.Count} users!", "TinderSuite");
        }
    }
}