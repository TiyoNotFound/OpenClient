using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerListApp
{
    public partial class Form1 : Form
    {
        private const string ApiBaseUrl = "https://api.open.mp/servers/";

        public Form1()
        {
            InitializeComponent();
        }

        private async void getServerInfoButton_Click(object sender, EventArgs e)
        {
            string ipAddress = ipAddressTextBox.Text;
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = ApiBaseUrl + ipAddress;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Display JSON response in the textbox for debugging
                    jsonTextBox.Text = responseBody;

                    if (response.IsSuccessStatusCode)
                    {
                        ServerInfo serverInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<ServerInfo>(responseBody);
                        DisplayServerInfo(serverInfo);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve server information: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ServerInfo
        {
            public CoreInfo core { get; set; }
            public RuInfo ru { get; set; }

            public class CoreInfo
            {
                public string hn { get; set; }
                public int pc { get; set; }
                public int pm { get; set; }
                public string gm { get; set; }
            }

            public class RuInfo
            {
                public string allowed_clients { get; set; }
                public string artwork { get; set; }
                public string lagcomp { get; set; }
                public string mapname { get; set; }
                public string version { get; set; }
                public string weather { get; set; }
                public string weburl { get; set; }
                public string worldtime { get; set; }
            }
        }

        private void DisplayServerInfo(ServerInfo serverInfo)
        {
            hostnameLabel.Text = $"Hostname: {serverInfo.core.hn}";
            playersLabel.Text = $"Players: {serverInfo.core.pc}/{serverInfo.core.pm}";
            gamemodeLabel.Text = $"Gamemode: {serverInfo.core.gm}";
            allowedClientsLabel.Text = $"Allowed Clients: {serverInfo.ru.allowed_clients}";
            artworkLabel.Text = $"Artwork: {serverInfo.ru.artwork}";
            lagcompLabel.Text = $"Lag Compensation: {serverInfo.ru.lagcomp}";
            mapnameLabel.Text = $"Map Name: {serverInfo.ru.mapname}";
            versionLabel.Text = $"Version: {serverInfo.ru.version}";
            weatherLabel.Text = $"Weather: {serverInfo.ru.weather}";
            weburlLabel.Text = $"Web URL: {serverInfo.ru.weburl}";
            worldtimeLabel.Text = $"World Time: {serverInfo.ru.worldtime}";
        }
    }
}
