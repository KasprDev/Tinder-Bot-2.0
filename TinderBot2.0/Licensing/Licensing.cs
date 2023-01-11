using System.Management;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace TinderBot2._0.Licensing
{
    public class Licensing
    {
        public Licensing()
        {
            Url = "https://licensing.deviar.net";
            SoftwareId = 3;
        }

        private static readonly HttpClient client = new HttpClient();
        public string Url { get; set; }
        public int SoftwareId { get; set; }
        public double Version { get; set; } = 1.2;

        public void SecurityCheck()
        {
            var hosts = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"));

            if (hosts.Contains("licensing.deviar.net"))
                Environment.Exit(0);
        }

        public async Task<bool> LogUsage(string note)
        {
            var values = new Dictionary<string, object>
            {
                { "Note", note },
                { "LicenseKey", File.ReadAllText("license.lic") }
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{Url}/api/usage/log", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var s = JsonConvert.DeserializeObject<LicensingResponse>(responseString);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(s.Message);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }

            return false;
        }

        public async Task<bool> RegisterLicense(string key)
        {
            SecurityCheck();

            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (var mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }

            var values = new Dictionary<string, object>
            {
                { "SoftwareId", SoftwareId },
                { "Fingerprint", id },
                { "Key", key }
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{Url}/api/license/validate", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var s = JsonConvert.DeserializeObject<LicensingResponse>(responseString);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    File.Delete("license.lic");
                    MessageBox.Show(s.Message);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }

            return false;
        }

        public async void ValidateLicense(string key)
        {
            SecurityCheck();

            var mbs = new System.Management.ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (var mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }

            var values = new Dictionary<string, object>
            {
                { "SoftwareId", SoftwareId },
                { "Fingerprint", id },
                { "Key", key }
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{Url}/api/license/validate", content);

                var responseString = await response.Content.ReadAsStringAsync();

                var s = JsonConvert.DeserializeObject<LicensingResponse>(responseString);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(s.Message);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(0);
            }
        }
    }
}
