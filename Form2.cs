using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ProjectAlexKadyn
{
    public partial class frmViewCollection : Form
    {
        public float value;
        public string name;
        public string selectedItem;

        static frmHome home = new frmHome();
        static frmAddNewItem itemPage = new frmAddNewItem();

        Collection collectionCurrent = new Collection();
        Collection collectionDefault = new Collection();

        public frmViewCollection()
        {
            InitializeComponent();
        }

        private void frmViewCollection_Load(object sender, System.EventArgs e)
        {
            collectionDefault.collectionName = "Add New Collection";
            collectionDefault.collectionValue = "0.00";

            collectionCurrent.collectionName = name;
            collectionCurrent.collectionValue = value.ToString();

            if (name == collectionDefault.collectionName)
            {
                txtTotalValue.Text = collectionDefault.collectionValue;
                txtCollectionName.Text = collectionDefault.collectionName;
            }
            else
            {
                txtCollectionName.Text = collectionCurrent.collectionName;
                txtTotalValue.Text = collectionCurrent.collectionValue;
            }

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            itemPage.name = collectionCurrent.collectionName;
            itemPage.value = Int32.Parse(collectionCurrent.collectionValue);
            itemPage.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAsCurrent_Click(object sender, EventArgs e)
        {
            if (collectionCurrent.collectionName != collectionDefault.collectionName)
            {
                home.lstCollections.Items.Remove(home.lstCollections.SelectedItem);
            }
            collectionCurrent.collectionName = txtCollectionName.Text;
            collectionCurrent.collectionValue = value.ToString();

            home.lstCollections.Items.Add(new Collection { collectionName = collectionCurrent.collectionName, collectionValue = collectionCurrent.collectionValue });

            home.Show();
            this.Hide();
        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {
            collectionCurrent.collectionName = txtCollectionName.Text;
            collectionCurrent.collectionValue = value.ToString();

            home.lstCollections.Items.Add(new Collection { collectionName = collectionCurrent.collectionName, collectionValue = collectionCurrent.collectionValue });

            home.Show();
            this.Hide();
        }

    }
}
