using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI.Forms.Administration
{
    public partial class AllEmployee : Form
    {
        public AllEmployee()
        {
            InitializeComponent();
        }

        private void AllEmployee_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet_Users.tblUser' . Możesz go przenieść lub usunąć.
            this.tblUserTableAdapter.Fill(this.companyDBDataSet_Users.tblUser);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet_Users.tblUser' . Możesz go przenieść lub usunąć.
            this.tblUserTableAdapter.Fill(this.companyDBDataSet_Users.tblUser);

        }
    }
}
