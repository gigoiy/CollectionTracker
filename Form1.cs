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

namespace ProjectAlexKadyn
{

    public partial class frmHome : Form
    {
        public string collection;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            collection = lstCollections.Text.ToString();
            frmViewCollection frmViewCollection = new frmViewCollection();
            frmViewCollection.collectionName = collection;
            frmViewCollection.Show(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
