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
            using (DB db = new DB())
            {
                if (db.Users.Any(x => x.UserName.Equals(cbAdminPicEmployee.Text)))
                {

                    txtAdminConfirmEmail.Text = db.Users.Where(x => x.UserName == cbAdminPicEmployee.Text)
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
/*
        private void cbAdminPicEmployee_TextChanged(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                if (db.Users.Any(x => x.UserName.Equals(cbAdminPicEmployee.Text)))
                {

                    txtAdminConfirmEmail.Text = db.Users.Where(x => x.UserName == cbAdminPicEmployee.Text)
                        .Select(x => x.Email)
                        .FirstOrDefault()
                        .ToString();
                }
            }
        }
        */
        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            //Changing password of selected user

            using (DB db = new DB())
            {
                if (txtAdminPassword.Text != txtAdminPasswordConfirm.Text)
                {
                    //red popup
                    MessageBox.Show("xd", "Wrong password");
                }

                tblUser model = new tblUser()
                {
                    
                    UserId = db.Users.Where(x => x.UserName == cbAdminPicEmployee.Text).Select(x => x.UserId).FirstOrDefault(),
                    UserName = cbAdminPicEmployee.Text, 
                    Password = txtAdminPassword.Text
                };

                // zmienić hasło osobie o username i email  
                db.Users.Attach(model);
                db.Entry(model).Property(x => x.Password).IsModified = true;
                db.SaveChanges();

                //greenpopup
                MessageBox.Show("xd", "Password was updated");

            }
        }
    }
}
