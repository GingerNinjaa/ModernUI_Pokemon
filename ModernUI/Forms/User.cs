using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class User : Form
    {
        tblUser CurentUser;
        public User(tblUser user)
        {
            CurentUser = user;
            InitializeComponent();

            setUserData();


        }

        private void setUserData()
        {
            lblUserNameShow.Text = CurentUser.UserName;
            lblFirstNameShow.Text = CurentUser.FirstName;
            lblLastNameShow.Text = CurentUser.LastName;
            lblEmailShow.Text = CurentUser.Email;
            lblPositionShow.Text = CurentUser.Position;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
