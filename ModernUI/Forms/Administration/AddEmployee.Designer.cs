﻿namespace ModernUI.Forms.Administration
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAdminPickPosition = new System.Windows.Forms.ComboBox();
            this.cbAdminPickRole = new System.Windows.Forms.ComboBox();
            this.companyDBDataSet_ALL = new ModernUI.CompanyDBDataSet_ALL();
            this.tblPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPositionTableAdapter = new ModernUI.CompanyDBDataSet_ALLTableAdapters.tblPositionTableAdapter();
            this.txtAdminAddPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtAdminAddPassword = new System.Windows.Forms.TextBox();
            this.txtAdminAddUserName = new System.Windows.Forms.TextBox();
            this.txtAdminAddEmail = new System.Windows.Forms.TextBox();
            this.txtAdminAddLastName = new System.Windows.Forms.TextBox();
            this.txtAdminAddFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdminAddClose = new System.Windows.Forms.Button();
            this.tblUserRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserRoleTableAdapter = new ModernUI.CompanyDBDataSet_ALLTableAdapters.tblUserRoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet_ALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserRoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(14, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(14, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(14, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(14, 453);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Permissions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(14, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Confirm Password";
            // 
            // cbAdminPickPosition
            // 
            this.cbAdminPickPosition.DataSource = this.tblPositionBindingSource;
            this.cbAdminPickPosition.DisplayMember = "PositionName";
            this.cbAdminPickPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdminPickPosition.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbAdminPickPosition.FormattingEnabled = true;
            this.cbAdminPickPosition.Location = new System.Drawing.Point(203, 392);
            this.cbAdminPickPosition.Name = "cbAdminPickPosition";
            this.cbAdminPickPosition.Size = new System.Drawing.Size(172, 29);
            this.cbAdminPickPosition.TabIndex = 24;
            this.cbAdminPickPosition.ValueMember = "PositionName";
            // 
            // cbAdminPickRole
            // 
            this.cbAdminPickRole.DataSource = this.tblUserRoleBindingSource;
            this.cbAdminPickRole.DisplayMember = "RoleName";
            this.cbAdminPickRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdminPickRole.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbAdminPickRole.FormattingEnabled = true;
            this.cbAdminPickRole.Location = new System.Drawing.Point(203, 449);
            this.cbAdminPickRole.Name = "cbAdminPickRole";
            this.cbAdminPickRole.Size = new System.Drawing.Size(172, 29);
            this.cbAdminPickRole.TabIndex = 25;
            this.cbAdminPickRole.ValueMember = "RoleName";
            // 
            // companyDBDataSet_ALL
            // 
            this.companyDBDataSet_ALL.DataSetName = "CompanyDBDataSet_ALL";
            this.companyDBDataSet_ALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPositionBindingSource
            // 
            this.tblPositionBindingSource.DataMember = "tblPosition";
            this.tblPositionBindingSource.DataSource = this.companyDBDataSet_ALL;
            // 
            // tblPositionTableAdapter
            // 
            this.tblPositionTableAdapter.ClearBeforeFill = true;
            // 
            // txtAdminAddPasswordConfirm
            // 
            this.txtAdminAddPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddPasswordConfirm.Location = new System.Drawing.Point(237, 312);
            this.txtAdminAddPasswordConfirm.Name = "txtAdminAddPasswordConfirm";
            this.txtAdminAddPasswordConfirm.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddPasswordConfirm.TabIndex = 29;
            // 
            // txtAdminAddPassword
            // 
            this.txtAdminAddPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddPassword.Location = new System.Drawing.Point(237, 274);
            this.txtAdminAddPassword.Name = "txtAdminAddPassword";
            this.txtAdminAddPassword.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddPassword.TabIndex = 30;
            // 
            // txtAdminAddUserName
            // 
            this.txtAdminAddUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddUserName.Location = new System.Drawing.Point(237, 229);
            this.txtAdminAddUserName.Name = "txtAdminAddUserName";
            this.txtAdminAddUserName.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddUserName.TabIndex = 31;
            // 
            // txtAdminAddEmail
            // 
            this.txtAdminAddEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddEmail.Location = new System.Drawing.Point(237, 137);
            this.txtAdminAddEmail.Name = "txtAdminAddEmail";
            this.txtAdminAddEmail.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddEmail.TabIndex = 32;
            // 
            // txtAdminAddLastName
            // 
            this.txtAdminAddLastName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddLastName.Location = new System.Drawing.Point(237, 86);
            this.txtAdminAddLastName.Name = "txtAdminAddLastName";
            this.txtAdminAddLastName.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddLastName.TabIndex = 33;
            // 
            // txtAdminAddFirstName
            // 
            this.txtAdminAddFirstName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminAddFirstName.Location = new System.Drawing.Point(237, 29);
            this.txtAdminAddFirstName.Name = "txtAdminAddFirstName";
            this.txtAdminAddFirstName.Size = new System.Drawing.Size(200, 27);
            this.txtAdminAddFirstName.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(678, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminAddClose
            // 
            this.btnAdminAddClose.BackColor = System.Drawing.Color.Green;
            this.btnAdminAddClose.FlatAppearance.BorderSize = 0;
            this.btnAdminAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAddClose.Location = new System.Drawing.Point(786, 12);
            this.btnAdminAddClose.Name = "btnAdminAddClose";
            this.btnAdminAddClose.Size = new System.Drawing.Size(35, 35);
            this.btnAdminAddClose.TabIndex = 37;
            this.btnAdminAddClose.Text = "X";
            this.btnAdminAddClose.UseVisualStyleBackColor = false;
            this.btnAdminAddClose.Click += new System.EventHandler(this.btnAdminAddClose_Click);
            // 
            // tblUserRoleBindingSource
            // 
            this.tblUserRoleBindingSource.DataMember = "tblUserRole";
            this.tblUserRoleBindingSource.DataSource = this.companyDBDataSet_ALL;
            // 
            // tblUserRoleTableAdapter
            // 
            this.tblUserRoleTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(833, 535);
            this.Controls.Add(this.btnAdminAddClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdminAddFirstName);
            this.Controls.Add(this.txtAdminAddLastName);
            this.Controls.Add(this.txtAdminAddEmail);
            this.Controls.Add(this.txtAdminAddUserName);
            this.Controls.Add(this.txtAdminAddPassword);
            this.Controls.Add(this.txtAdminAddPasswordConfirm);
            this.Controls.Add(this.cbAdminPickRole);
            this.Controls.Add(this.cbAdminPickPosition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Opacity = 0.9D;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddEmployee_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet_ALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserRoleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAdminPickPosition;
        private System.Windows.Forms.ComboBox cbAdminPickRole;
        private CompanyDBDataSet_ALL companyDBDataSet_ALL;
        private System.Windows.Forms.BindingSource tblPositionBindingSource;
        private CompanyDBDataSet_ALLTableAdapters.tblPositionTableAdapter tblPositionTableAdapter;
        private System.Windows.Forms.TextBox txtAdminAddPasswordConfirm;
        private System.Windows.Forms.TextBox txtAdminAddPassword;
        private System.Windows.Forms.TextBox txtAdminAddUserName;
        private System.Windows.Forms.TextBox txtAdminAddEmail;
        private System.Windows.Forms.TextBox txtAdminAddLastName;
        private System.Windows.Forms.TextBox txtAdminAddFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdminAddClose;
        private System.Windows.Forms.BindingSource tblUserRoleBindingSource;
        private CompanyDBDataSet_ALLTableAdapters.tblUserRoleTableAdapter tblUserRoleTableAdapter;
    }
}