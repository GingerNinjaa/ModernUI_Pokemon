using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Przesuwanie okna PART 1 
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ModernUI.Data;

namespace ModernUI.Forms.Stock
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AddStock_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void txtAddProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

 

           
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet_Category.tblCategory' . Możesz go przenieść lub usunąć.
            this.tblCategoryTableAdapter.Fill(this.companyDBDataSet_Category.tblCategory);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet.tblProducts' . Możesz go przenieść lub usunąć.
            // this.tblProductsTableAdapter.Fill(this.companyDBDataSet.tblProducts);

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            tblProducts model = new tblProducts();
            using (CompanyDBEntities db = new CompanyDBEntities())
            {
                model.Name = txtAddProductName.Text;
                model.Description = txtAddProductDescription.Text;
                model.Price = decimal.Parse(txtAddProductPrice.Text);
                model.CategoryName = cbAddProductCategory.Text;

                db.tblProducts.Add(model);
                db.SaveChanges();
            }
        }

        private void btnAddProductClear_Click(object sender, EventArgs e)
        {
            txtAddProductName.Text = "";
            txtAddProductDescription.Text = "";
            txtAddProductPrice.Text = "";
            cbAddProductCategory.Text = "";
        }
    }
}
