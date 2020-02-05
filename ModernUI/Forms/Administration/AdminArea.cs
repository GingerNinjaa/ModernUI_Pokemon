﻿using System;
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
    public partial class AdminArea : Form
    {
        public AdminArea()
        {
            InitializeComponent();
            openChildForm(new AllEmployee());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormAdmin.Controls.Add(childForm);
            panelChildFormAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdminAllEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new AllEmployee());
        }

        private void btnAdminChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}