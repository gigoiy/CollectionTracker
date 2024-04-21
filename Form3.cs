using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ProjectAlexKadyn
{
    public partial class frmAddNewItem : Form
    {
        Collection collectionCurrent = new Collection();

        public float value;
        public string name;
        public string selectedItem;
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
                if (selectedItem == null)
                {
                    searchItem();
                    collectionCurrent.item[0, 0] = txtModel.Text;
                    collectionCurrent.item[0, 1] = value.ToString();
                }
            }
            else
            {
                Console.WriteLine("ERROR... Please fill out all areas for the item.");
            }
        }

        GetResults.Rootobject result;

        private void searchItem()
        {
            //Call the API
            //Uses RestSharp

            var client = new RestClient("https://api.sandbox.ebay.com/buy/browse/v1");
            var request = new RestRequest("/item_summary/search?q="+txtModel.Text);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                //Convert the raw data
                result = JsonConvert.DeserializeObject<GetResults.Rootobject>(rawResponse);

                if (result != null)
                {
                    foreach (var obj in result.itemSummaries)
                    {
                        //Add average value calculations
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtDecription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }
    }
}
