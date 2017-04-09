using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace OpenData
{
    public partial class Form1 : Form
    {
        private static string openDataFormat = "xml"; //joson | xml
        private string url = $"http://opendata.epa.gov.tw/webapi/api/rest/datastore/315070000H-000001/?format={openDataFormat}&token=QPJM2Z+93U2Ri9BUUSgCDg";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetOpenData();
        }
        private void GetOpenData()
        {
            
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string oriOpenData = webClient.DownloadString(url);

                if (openDataFormat == "xml")
                    ParseXmlData(oriOpenData);

            }

        }
        private void ParseXmlData(string oriOpenData)
        {
            try
            {
                XDocument xmlDoc = new XDocument();
                xmlDoc = XDocument.Parse(oriOpenData);
                IEnumerable<RainTenMin> rainTenMins = from rows in xmlDoc.Descendants("Data")
                    select new RainTenMin
                    {
                        SiteId = rows.Element("SiteId").Value
                        ,
                        SiteName = rows.Element("SiteName").Value
                        ,
                        County = rows.Element("County").Value
                        ,
                        Township = rows.Element("Township").Value
                        ,
                        TWD67Lon = decimal.Parse(rows.Element("TWD67Lon").Value)
                        ,
                        TWD67Lat = decimal.Parse(rows.Element("TWD67Lat").Value)
                        ,
                        Rainfall6hr = decimal.Parse(rows.Element("Rainfall6hr").Value)
                        ,
                        Rainfall12hr = decimal.Parse(rows.Element("Rainfall12hr").Value)
                        ,
                        Rainfall24hr = decimal.Parse(rows.Element("Rainfall24hr").Value)
                                                ,
                        Now = decimal.Parse(rows.Element("Now").Value)
                        ,
                        Unit = rows.Element("Unit").Value
                        ,
                        PublishTime =rows.Element("PublishTime").Value
                    };
                string sitId = txtSiteId.Text;
                if (sitId == "")
                    sitId = "C0W160";
                RainTenMin singleRow = rainTenMins.FirstOrDefault<RainTenMin>(d => d.SiteId == sitId);
                if (singleRow != null)
                {
                    txtSiteId.Text = singleRow.SiteId;
                    txtSiteName.Text = singleRow.SiteName;
                    txtCountry.Text = singleRow.County;
                    txtTownship.Text = singleRow.Township;
                    txtTWD67Lon.Text = singleRow.TWD67Lon.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }

}
