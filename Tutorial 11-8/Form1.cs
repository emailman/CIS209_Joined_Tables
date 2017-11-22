using System;
using System.Windows.Forms;

namespace Tutorial_11_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            productBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(productDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table
            productTableAdapter.Fill(productDataSet.Product);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            productTableAdapter.SearchDescription(
                productDataSet.Product, tbxSearch.Text);
        }
    }
}
