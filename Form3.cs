using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using eBayAPI;

namespace ProjectAlexKadyn
{
    public partial class frmAddNewItem : Form
    {
        public frmAddNewItem()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtModel.Text != string.Empty)
            {
                searchItem();
            }
            else
            {
                Console.WriteLine("ERROR... Please fill out all areas for the item.");
            }
        }

        GetResults.Itemsummary result;

        private void searchItem()
        {
            //Call the API
            //Uses RestSharp

            var client = new RestClient(/*Input endpoint URI of API here without last argument*/);
            var request = new RestRequest(/*Input last argument of the address*/);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK )
            {
                string rawResponse = response.Content;

                //Convert the raw data
                result = JsonConvert.DeserializeObject<GetResults.Itemsummary>(rawResponse);

                if (result != null)
                {
                  //Add processing of the search result, maybe assign items to collection class like in frmViewCollection?
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
