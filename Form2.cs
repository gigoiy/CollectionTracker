using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectAlexKadyn
{
    public partial class frmViewCollection : Form
    {
        public double totalValue;

        frmHome home = new frmHome();
        public string collectionName { get; set; }
        public frmViewCollection()
        {
            InitializeComponent();
        }

        private void frmViewCollection_Load(object sender, System.EventArgs e)
        {
            txtCollectionName.Text = collectionName;
            totalValue = 0.00;
            txtTotalValue.Text = totalValue.ToString("C", CultureInfo.CurrentCulture);


            /*
             * Oh boy it's about to get slightly hairy...
             * 
             * Prerequisites for this part of the code:
             * 
             * - We need to start doing the 4D array with all the data of each collection that is saved in the current session
             * - The 4D array will contain these four variables: Collection name, model of each item, short description of each item, each item's value
             * - Every time a new collection is saved, it saves the data of the collection to the 4D array and adds collectionName to lstCollections in frmHome
             * - Alex, if you don't know how 4D arrays work, research them real quick and understanding what I'm trying to do 
             * should be extremely straight forward with your new found knowledge afterwards 
             * 
             * Goal:
             * 
             * The goal of this block of code is to set the default total value of the collection in txtTotalValue to the actual value of the collection when btnView is 
             * clicked in frmHome, that's if the collection is not the default "Add New Collection" and was a previously saved collection with a value greater than zero.
             * 
             * How the Code Should Work:
             * 
             * 1. Matches collectionName of the class to the collectionName of the 4D array
             * 2. Indexes through each modelIdentifier dimension of the array of the specific collectionName value
             * 3. As it's indexing through each modelIdentifier under that collectionName, it grabs the itemValue from the itemValue dimension under that modelIdentifier
             * 4. Sums up the total of every itemValue and sets totalValue of the class to that summed-up total
             * 5. Converts totalValue to currency as a string and displays it in txtTotalValue
             * 6. Put the code in this block and it should do it's thing once btnView is clicked in frmHome
             */
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {

            frmAddNewItem form = new frmAddNewItem();
            form.Show(); // using this to open up form 3

            //will save collection name in form 3 to whatever was set into the text box previously

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAsCurrent_Click(object sender, EventArgs e)
        {

            CollectionName newCollectionAdd = new CollectionName();

            if (this.collectionName == "Add New Item")
            {
                home.lstCollections.Items.Remove("Add New Collection");
                home.lstCollections.Items.Add("Add New Collection");
            }
            
            newCollectionAdd.collectionName = txtCollectionName.Text;
            home.lstCollections.Items.Add(newCollectionAdd.collectionName);
            home.Show();
            this.Hide();
        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {
            // new CollectionName(txtCollectionName.Text);
            // should save a new colleciton name, which can then be formatted for items with the arraay
            CollectionName newCollection = new CollectionName();
            newCollection.collectionName = txtCollectionName.Text;
            home.lstCollections.Items.Add(newCollection.collectionName);
            collectionName = newCollection.collectionName;
            home.Show();
            this.Hide();

        }

        private void gridItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
