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
using ProjectAlexKadyn.eBayAPI;

namespace ProjectAlexKadyn
{
    public partial class frmAddNewItem : Form
    {
        public frmAddNewItem(string collectionName)
        {
            InitializeComponent();
            string Collection;
            Collection = collectionName;
            // by using a constructor, the collection name is carried from from2 to 3...

        }

        public void searchItem()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && txtModel.Text != "" && ddCategory.Text != "")
            {
                Collection.item[0, 0] = txtModel.Text;
                Collection.item[1, 0] = txtDescription.Text;
                Collection.item[2, 0] = ddCategory.Text;
            }
            else
            {
                Console.WriteLine("ERROR... Please fill out all areas for the item.");
            }
            // trying to set the specific array for each item when added. troubleshooting needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtDecription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
