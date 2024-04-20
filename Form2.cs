using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ProjectAlexKadyn
{
    public partial class frmViewCollection : Form
    {
        public string totalValue;
        public float value;
        public string name;

        static frmHome home = new frmHome();

        Collection collectionCurrent = new Collection();
        Collection collectionDefault = new Collection();

        public frmViewCollection()
        {
            InitializeComponent();
        }

        private void frmViewCollection_Load(object sender, System.EventArgs e)
        {
            collectionDefault.collectionName = "Add New Collection";
            collectionDefault.collectionValue = "$0.00";

            collectionCurrent.collectionName = name;
            collectionCurrent.collectionValue = totalValue;

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

            frmAddNewItem form = new frmAddNewItem();
            form.Show();

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
            collectionCurrent.collectionValue = totalValue;

            home.lstCollections.Items.Add(new Collection { collectionName = collectionCurrent.collectionName, collectionValue = collectionCurrent.collectionValue });

            home.Show();
            this.Hide();
        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {
            collectionCurrent.collectionName = txtCollectionName.Text;
            collectionCurrent.collectionValue = totalValue;

            home.lstCollections.Items.Add(new Collection { collectionName = collectionCurrent.collectionName, collectionValue = collectionCurrent.collectionValue });

            home.Show();
            this.Hide();
        }

        private void gridItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
