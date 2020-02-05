using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI.Forms.Stock
{
    public partial class AllStock : Form
    {
        public AllStock()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStock_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet1.tblProducts' . Możesz go przenieść lub usunąć.
            this.tblProductsTableAdapter.Fill(this.companyDBDataSet1.tblProducts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet_AllProduct.tblProducts' . Możesz go przenieść lub usunąć.
          //  this.tblProductsTableAdapter1.Fill(this.companyDBDataSet_AllProduct.tblProducts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet.tblProducts' . Możesz go przenieść lub usunąć.
          //  this.tblProductsTableAdapter.Fill(this.companyDBDataSet.tblProducts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet.tblProducts' . Możesz go przenieść lub usunąć.
            // this.tblProductsTableAdapter.Fill(this.companyDBDataSet.tblProducts);

        }
    }
}
