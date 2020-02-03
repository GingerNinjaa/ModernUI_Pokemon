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
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            // chowamy submenu
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;

        }

        //chowamy submenu które zostało pokazane wcześniej
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
            if (panelPlaylistSubmenu.Visible == true)
            {
                panelPlaylistSubmenu.Visible = true;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            // jeśli submenu jest schowane 
            if (subMenu.Visible == false)
            {
                //chowaj wszystkie submenu
                // hideSubMenu();

                //pokaż to nasze submenu
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        #region MediaSubMenuButtons

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowEmployee());

            //hideSubMenu();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new AddEmployee());

            /*
             * Jakiś kod
             * 
             * 
             */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Jakiś kod
             * 
             * 
             */

        }
        #endregion


        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }

        #region PlaylistSubMenuButtons

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             * 
             * Jakiś kod
             * 
             * 
             */

            //hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             * Jakiś kod
             * 
             * 
             */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             * Jakiś kod
             * 
             * 
             */
        }

        #endregion



        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

           
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void btnDeleteEmplayee_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dlewandowski.pl");
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
