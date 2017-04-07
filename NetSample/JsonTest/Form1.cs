using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json;
namespace JsonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string url = $"http://140.138.6.96/Env.json";
        private async void btnGet_Click(object sender, EventArgs e)
        {
            string err = "";
            Environ env = GetEnv(ref err);   //方法1
            //Environ env = await GetResponse(ref err);  //方法2
            dataGridView1.DataSource = env.ENV;
        }
        public static Environ GetEnv(ref string err)
        {
            Environ env = new Environ();
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    string json = webClient.DownloadString(url);
                    env = JsonConvert.DeserializeObject<Environ>(json);
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return env;
        }
        public static async Task<Environ> GetResponse(ref string err)
        {
            Environ env = null;
            try
            {
                using (var client = new HttpClient())
                {
                    //C# 6 called Interpolated Strings, {變數名稱} = > {authKey} {message}

                    client.DefaultRequestHeaders.Accept.Clear();
                    //Header宣告成Json格式
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(url); //呼叫JSON URL

                    if (!response.IsSuccessStatusCode) return null; //失敗直接返回

                    var result = await response.Content.ReadAsStringAsync(); //讀取資料

                    //將返回的Json 轉到 Student物件
                    var js = new DataContractJsonSerializer(typeof(Environ));
                    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    env = (Environ)js.ReadObject(ms);                     
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return env;
        }
    }
}
