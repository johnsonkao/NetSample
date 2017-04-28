using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Newtonsoft.Json;
namespace JsonTest
{
    public partial class UVForm : Form
    {
        public UVForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int? uvi = await GetUVI(txtLocation.Text);
            if (uvi.HasValue)
                lblUVI.Text = uvi.ToString();
            else
                lblUVI.Text = "not found";
        }
        public async Task<int?> GetUVI(string location)
        {
            string err = "";
            //string token = "KYfUA2YT6kG66dQeBDhWDg";
            string url = $"http://opendata.epa.gov.tw/ws/Data/UV/?$filter=SiteName%20eq%20%27{location}%27&$orderby=PublishTime%20desc&$skip=0&$top=1000&format=json";
            int uvi_value = 0;
            string json = "";
            List<UV> uv =null;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    json = webClient.DownloadString(url);
                    uv = JsonConvert.DeserializeObject<List<UV>>( json);
                }
            }   
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
            if (uv == null )
                MessageBox.Show("查無資料");
            else
                uvi_value = int.Parse(uv[0].UVI);
            return uvi_value;

        }
    }
}
