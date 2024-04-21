using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Routing.Constraints;

namespace ProjectAlexKadyn
{
    public partial class frmViewCollection : Form
    {
        public float value;
        public string[,] items = new string[100, 100];
        public string name;
        public string previousItem;
        private bool searchClosed = false;

        static frmHome home = new frmHome();
        frmAddNewItem itemPage = new frmAddNewItem();

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

            collectionCurrent.collectionValue = value.ToString();
            collectionCurrent.collectionName = name;

            if (collectionCurrent.collectionName == collectionDefault.collectionName && collectionCurrent.collectionValue == collectionDefault.collectionValue)
            {
                txtTotalValue.Text = collectionDefault.collectionValue;
                txtCollectionName.Text = collectionDefault.collectionName;
            }
            else if (searchClosed == true)
            {

                items = itemPage.items.Clone() as string[,];
                previousItem = itemPage.previousItem;

                name = itemPage.name;
                txtCollectionName.Text = itemPage.name;
                txtTotalValue.Text = (itemPage.value + float.Parse(txtTotalValue.Text)).ToString();

                value = float.Parse(txtTotalValue.Text);

                int[] index = ItemSearch.FindIndex(items, previousItem);
                gridItems.Controls.Add(new TextBox { Text = items[index[0], 0] }, 0, index[0]);
                gridItems.Controls.Add(new TextBox { Text = items[index[0], 1] }, 1, index[0]);

                searchClosed = false;

            }
            else
            {
                txtCollectionName.Text = collectionCurrent.collectionName;
                txtTotalValue.Text = collectionCurrent.collectionValue;

            }

            this.Update();

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            collectionCurrent.collectionName = txtCollectionName.Text;
            collectionCurrent.collectionValue = value.ToString();
            itemPage.name = collectionCurrent.collectionName;
            itemPage.value = float.Parse(collectionCurrent.collectionValue);
            itemPage.previousItem = previousItem;
            itemPage.items = items.Clone() as string[,];
            searchClosed = true;
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
