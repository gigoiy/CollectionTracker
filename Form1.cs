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
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewCollection form = new frmViewCollection();
            form.collectionName = lstCollections.SelectedItem.ToString();
            form.Show();
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
