using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlexKadyn
{
    public partial class frmViewCollection : Form
    {
        public double totalValue;
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
            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAsCurrent_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {

        }
    }
}
