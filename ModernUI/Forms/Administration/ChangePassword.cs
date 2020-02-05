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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'companyDBDataSet_Users.tblUser' . Możesz go przenieść lub usunąć.
            this.tblUserTableAdapter.Fill(this.companyDBDataSet_Users.tblUser);

        }

        private void btnAdminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
