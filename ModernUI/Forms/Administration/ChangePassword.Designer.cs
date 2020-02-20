namespace ModernUI.Forms.Administration
{
    partial class ChangePassword
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
            this.cbAdminPicEmployee = new System.Windows.Forms.ComboBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDBDataSetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
  //          this.companyDBDataSet_Users = new ModernUI.CompanyDBDataSet_Users();
 //           this.tblUserTableAdapter = new ModernUI.CompanyDBDataSet_UsersTableAdapters.tblUserTableAdapter();
            this.txtAdminConfirmEmail = new System.Windows.Forms.TextBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnAdminClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminPasswordConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetUsersBindingSource)).BeginInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose an employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm by Email";
            // 
            // cbAdminPicEmployee
            // 
            this.cbAdminPicEmployee.DataSource = this.tblUserBindingSource;
            this.cbAdminPicEmployee.DisplayMember = "UserName";
            this.cbAdminPicEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdminPicEmployee.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbAdminPicEmployee.FormattingEnabled = true;
            this.cbAdminPicEmployee.Location = new System.Drawing.Point(253, 46);
            this.cbAdminPicEmployee.Name = "cbAdminPicEmployee";
            this.cbAdminPicEmployee.Size = new System.Drawing.Size(172, 29);
            this.cbAdminPicEmployee.TabIndex = 16;
            this.cbAdminPicEmployee.ValueMember = "UserName";
//            this.cbAdminPicEmployee.TextChanged += new System.EventHandler(this.cbAdminPicEmployee_TextChanged);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.companyDBDataSetUsersBindingSource;
            // 
            // companyDBDataSetUsersBindingSource
            // 
 //           this.companyDBDataSetUsersBindingSource.DataSource = this.companyDBDataSet_Users;
            this.companyDBDataSetUsersBindingSource.Position = 0;
            // 
            // companyDBDataSet_Users
            // 
 //           this.companyDBDataSet_Users.DataSetName = "CompanyDBDataSet_Users";
 //           this.companyDBDataSet_Users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserTableAdapter
            // 
   //         this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // txtAdminConfirmEmail
            // 
            this.txtAdminConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminConfirmEmail.Location = new System.Drawing.Point(235, 98);
            this.txtAdminConfirmEmail.Name = "txtAdminConfirmEmail";
            this.txtAdminConfirmEmail.ReadOnly = true;
            this.txtAdminConfirmEmail.Size = new System.Drawing.Size(200, 27);
            this.txtAdminConfirmEmail.TabIndex = 28;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.Green;
            this.btnAddArticle.FlatAppearance.BorderSize = 0;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Location = new System.Drawing.Point(482, 231);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(106, 57);
            this.btnAddArticle.TabIndex = 29;
            this.btnAddArticle.Text = "Change password";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnAdminClose
            // 
            this.btnAdminClose.BackColor = System.Drawing.Color.Green;
            this.btnAdminClose.FlatAppearance.BorderSize = 0;
            this.btnAdminClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminClose.Location = new System.Drawing.Point(553, 12);
            this.btnAdminClose.Name = "btnAdminClose";
            this.btnAdminClose.Size = new System.Drawing.Size(35, 35);
            this.btnAdminClose.TabIndex = 33;
            this.btnAdminClose.Text = "X";
            this.btnAdminClose.UseVisualStyleBackColor = false;
            this.btnAdminClose.Click += new System.EventHandler(this.btnAdminClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Enter the Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Confirm Password";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminPassword.Location = new System.Drawing.Point(235, 151);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(200, 27);
            this.txtAdminPassword.TabIndex = 36;
            this.txtAdminPassword.TextChanged += new System.EventHandler(this.txtAdminPassword_TextChanged);
            // 
            // txtAdminPasswordConfirm
            // 
            this.txtAdminPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdminPasswordConfirm.Location = new System.Drawing.Point(235, 211);
            this.txtAdminPasswordConfirm.Name = "txtAdminPasswordConfirm";
            this.txtAdminPasswordConfirm.Size = new System.Drawing.Size(200, 27);
            this.txtAdminPasswordConfirm.TabIndex = 37;
            this.txtAdminPasswordConfirm.TextChanged += new System.EventHandler(this.txtAdminPasswordConfirm_TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.txtAdminPasswordConfirm);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminClose);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.txtAdminConfirmEmail);
            this.Controls.Add(this.cbAdminPicEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Opacity = 0.9D;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetUsersBindingSource)).EndInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAdminPicEmployee;
        private System.Windows.Forms.BindingSource companyDBDataSetUsersBindingSource;
//        private CompanyDBDataSet_Users companyDBDataSet_Users;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
//        private CompanyDBDataSet_UsersTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.TextBox txtAdminConfirmEmail;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnAdminClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminPasswordConfirm;
    }
}