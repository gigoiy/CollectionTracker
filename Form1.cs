using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ProjectAlexKadyn
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
            lstCollections.Items.Add(new Collection { collectionName = "Add New Collection", collectionValue = "0.00" });
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            frmViewCollection form = new frmViewCollection();
            form.name = ((Collection)lstCollections.SelectedItem).collectionName;
            form.value = Int32.Parse(((Collection)lstCollections.SelectedItem).collectionValue);
            this.Hide();
            form.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lstCollections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
