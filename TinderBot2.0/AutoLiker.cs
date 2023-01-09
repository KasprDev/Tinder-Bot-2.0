using SharpTinder;
using System.Security.Policy;
using TinderBot2_0;

namespace TinderBot2._0
{
    public partial class AutoLiker : Form
    {
        private CancellationTokenSource? _tokenSource { get; set; }
        private CancellationToken? _token { get; set; }

        public AutoLiker()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A list of your preferred ethnicities.", "Tinder Suite");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A list zodiac signs that you prefer to not date. Leave empty if you are open to all zodiac signs.", "Tinder Suite");
        }

        private void AutoLiker_Load(object sender, EventArgs e)
        {
            // Load ethnicity list.
            listEthnicities.Items.AddRange(TinderLists.Ethnicities);

            // Load zodiac sign list.
            listZodiac.Items.AddRange(TinderLists.StarSigns);

            // Load interest list.
            listDislikedHobbies.Items.AddRange(TinderLists.Hobbies);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                _tokenSource = new CancellationTokenSource();
                _token = _tokenSource.Token;

                btnStart.Text = "Stop";

                try
                {
                    while (true)
                    {
                        if (_tokenSource.IsCancellationRequested)
                            break;

                        var users = await Tinder.Instances.First().GetMatchCards();

                        if (users?.Data.Results == null)
                        {
                            MessageBox.Show("No match cards were loaded.", "Tinder Suite");
                            break;
                        }

                        foreach (var user in users.Data.Results)
                        {
                            if (_tokenSource.IsCancellationRequested)
                                break;

                            this.InvokeIfRequired(() =>
                            {
                                pictureBox1.LoadAsync(user.User.Photos.FirstOrDefault()?.Url);
                                lblName.Text = user.User.Name;
                                lblDistance.Text = $"{user.Distance} miles away";
                            });

                            var result = await ProcessUser(user);

                            if (result)
                            {
                                var like = await Tinder.Instances.First().LikeUser(user.User.Id);

                                if (like?.LikesRemaining == 0)
                                {
                                    Text = $"Auto Liker - {like?.LikesRemaining} likes remaining";
                                }

                                Text = $"Auto Liker - {like?.LikesRemaining} likes remaining";

                            }
                            else
                            {
                                await Tinder.Instances.First().PassUser(user.User.Id, user.User.SNumber);
                            }

                            await Task.Delay(2000);
                        }
                    }
                }
                finally
                {
                    lblName.Text = "N/A";
                    lblDistance.Text = "0 miles away";
                    pictureBox1.Image = null;
                }
            }
            else
            {
                _tokenSource?.Cancel();
                btnStart.Text = "Start";
            }
        }

        private async Task<bool> ProcessUser(TinderRecommendedUser user)
        {
            this.InvokeIfRequired(() =>
            {
                labelEthnicity.Text = "";
                labelZodiac.Text = "";
                labelIntent.Text = "";
                labelZodiac.ForeColor = Color.Black;
                labelIntent.ForeColor = Color.Black;
                labelEthnicity.ForeColor = Color.Black;
            });

            // This user is outside of the preferred distance range.
            if (numMaxDistance.Value < user.Distance)
                return false;

            var intentTypes = listRelationshipIntent.CheckedItems.Cast<string>().ToList();

            labelIntent.InvokeIfRequired(() =>
            {
                labelIntent.Text = user.User.RelationshipIntent?.BodyText;

                if (intentTypes.Any(x => x == user.User.RelationshipIntent?.BodyText))
                    labelIntent.ForeColor = Color.DarkRed;
            });

            var preferredZodiacs = listZodiac.CheckedItems.Cast<string>().ToList();
            var selectionName = user.User.Descriptors?.FirstOrDefault(x => x.Name == "Zodiac")?.Selections.First().Name;
            labelZodiac.Text = selectionName;

            // This user has an undesired zodiac sign. (Skips this step if the zodiac sign is null)
            if (selectionName != null && preferredZodiacs.Contains(selectionName))
            {
                labelZodiac.ForeColor = Color.DarkRed;
                return false;
            }

            if (labelIntent.ForeColor == Color.DarkRed)
                return false;

            labelEthnicity.InvokeIfRequired(() =>
            {
                labelEthnicity.Text = "Processing..";
            });

            // Get image data to process against the machine learning model.
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(user.User.Photos.FirstOrDefault()?.Url))
                {
                    var imageBytes =
                        await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

                    // await File.WriteAllBytesAsync(Path.Combine(Settings.TempPath, Guid.NewGuid() + ".jpg"), imageBytes);

                    DatingModel.ModelInput sampleData = new DatingModel.ModelInput()
                    {
                        ImageSource = imageBytes,
                    };

                    //Load model and predict output
                    var res = DatingModel.Predict(sampleData);
                    labelEthnicity.InvokeIfRequired(() =>
                    {
                        var preferredEthnicities = listEthnicities.CheckedItems.Cast<string>().ToList();

                        labelEthnicity.Text = res.PredictedLabel;

                        if (!preferredEthnicities.Contains(res.PredictedLabel))
                            labelEthnicity.ForeColor = Color.DarkRed;
                    });
                }
            }

            if (labelEthnicity.ForeColor == Color.DarkRed)
                return false;

            return true;
        }

        private void btnSaveMatchPreferences_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Select all of the intents that you are not interested in.\r\n\r\nFor example, do not select \"Long-term partner\" if you are looking for a hookup.",
                "Tinder Suite");
        }
    }
}
