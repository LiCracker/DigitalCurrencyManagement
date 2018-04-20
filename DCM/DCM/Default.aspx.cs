using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;

namespace DCM
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            updatePrices();
        }

        private async void updatePrices()
        {
            RootObject result = await GetResult();
            Label1.Text = "BTC";
            Label2.Text = result.BTC.ToString();
            Label3.Text = "ETH";
            Label4.Text = result.ETH.ToString();
            Label5.Text = "LTC";
            Label6.Text = result.LTC.ToString();
        }

        public static async Task<RootObject> GetResult()
        {
            string apiUrl = "https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,ETH,LTC&tsyms=USD";

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var rootResult = JsonConvert.DeserializeObject<RootObject>(result);
                    return rootResult;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}