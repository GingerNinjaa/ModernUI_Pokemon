using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ModernUI.Data;

namespace ModernUI.Forms.Administration
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void txtAdminPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            txtAdminPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {
            txtAdminPassword.UseSystemPasswordChar = true;
        }

        private void test()
        {
            using (CompanyDBEntities db = new CompanyDBEntities())
            {


                if (db.tblUser.Any(x => x.UserName.Equals(cbAdminPicEmployee.Text)))
                {

                    txtAdminConfirmEmail.Text = db.tblUser.Where(x => x.UserName == cbAdminPicEmployee.Text)
                        .Select(x => x.Email)
                        .FirstOrDefault()
                        .ToString();
                       
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
        }
    }
}
