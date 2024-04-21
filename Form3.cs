using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ProjectAlexKadyn
{
    public partial class frmAddNewItem : Form
    {
        Collection collectionCurrent = new Collection();
        frmViewCollection viewPage = new frmViewCollection();

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
                    selectedItem = collectionCurrent.item[0, 0];
                }
                else
                {
                    searchItem();
                    int index = Array.IndexOf(collectionCurrent.item, selectedItem);
                    collectionCurrent.item[index + 1, index] = txtModel.Text;
                    collectionCurrent.item[index + 1, index + 1] = value.ToString();
                }  
                
                //Next Steps:
                //Add item array, name, and value transfer to frmViewCollection
                //Populate table in frmViewCollection
                //Test OAuth authorization
                //Should be finished after that!

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
                    foreach (var itemsummary in result.itemSummaries)
                    {
                        value = value + Int32.Parse(itemsummary.price.value);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
