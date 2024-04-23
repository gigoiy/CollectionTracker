using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eBay.ApiClient.Auth.OAuth2;
using eBay.ApiClient.Auth.OAuth2.Model;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;

namespace ProjectAlexKadyn
{
    public partial class frmAddNewItem : Form
    {
        Collection collectionCurrent = new Collection();

        public float value;
        public float average = 0.00F;
        public string[,] items = new string[100, 100];
        public string name;
        public string previousItem;
        public frmAddNewItem()
        {
            InitializeComponent();

        }

        private void frmAddNewItem_Load(object sender, System.EventArgs e)
        {
            collectionCurrent.collectionName = name;
            collectionCurrent.collectionValue = value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtModel.Text != string.Empty)
            {
                if (previousItem == null)
                {
                    searchItem();
                    collectionCurrent.item[0, 0] = txtModel.Text;
                    collectionCurrent.item[0, 1] = average.ToString();
                    previousItem = collectionCurrent.item[0, 0];
                }
                else
                {
                    searchItem();
                    int[] index = ItemSearch.FindIndex(collectionCurrent.item, previousItem);
                    collectionCurrent.item[index[0] + 1, index[1]] = txtModel.Text;
                    collectionCurrent.item[index[0] + 1, index[1] + 1] = average.ToString();
                    previousItem = txtModel.Text;
                }

                items = collectionCurrent.item.Clone() as string[,];
                name = collectionCurrent.collectionName;
                value = average;
                average = 0.00F;

                //Next Steps:
                //Populate table in frmViewCollection
                //Should be finished after that!

            }
            else
            {
                Console.WriteLine("ERROR... Please fill out all areas for the item.");
            }
            this.Hide();
        }

        GetResults.Rootobject result;
        OAuth2Api auth = new OAuth2Api();
        List<string> scopes = new List<string>();


        private void searchItem()
        {
            //Call the API
            //Uses RestSharp

            scopes.Add("https://api.ebay.com/oauth/api_scope");
            var authresponse = auth.GetApplicationToken(OAuthEnvironment.SANDBOX, scopes);
            string token = authresponse.AccessToken.Token;
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
            var clientOptions = new RestClientOptions("https://api.sandbox.ebay.com/buy/browse/v1")
            {
                Authenticator = authenticator
            };
            var client = new RestClient(clientOptions);
            var request = new RestRequest("/item_summary/search?q=" + txtModel.Text);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                //Convert the raw data
                result = JsonConvert.DeserializeObject<GetResults.Rootobject>(rawResponse);


                foreach (var itemsummary in result.itemSummaries)
                {
                    average = average + float.Parse(itemsummary.price.value);
                }

                average = average / result.total;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmViewCollection();
        }
    }
}
