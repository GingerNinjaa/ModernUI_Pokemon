﻿namespace ModernUI.Forms.Stock
{
    partial class AddStock
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
            this.btnAddProductClear = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.txtAddProductDescription = new System.Windows.Forms.TextBox();
            this.txtAddProductPrice = new System.Windows.Forms.TextBox();
            this.cbAddProductCategory = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProductClear
            // 
            this.btnAddProductClear.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProductClear.FlatAppearance.BorderSize = 0;
            this.btnAddProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductClear.Location = new System.Drawing.Point(424, 497);
            this.btnAddProductClear.Name = "btnAddProductClear";
            this.btnAddProductClear.Size = new System.Drawing.Size(167, 57);
            this.btnAddProductClear.TabIndex = 1;
            this.btnAddProductClear.Text = "Clear";
            this.btnAddProductClear.UseVisualStyleBackColor = false;
            this.btnAddProductClear.Click += new System.EventHandler(this.btnAddProductClear_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.Green;
            this.btnAddArticle.FlatAppearance.BorderSize = 0;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Location = new System.Drawing.Point(666, 497);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(167, 57);
            this.btnAddArticle.TabIndex = 2;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(44, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Article Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(309, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(44, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(44, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(44, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Category";
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAddProductName.Location = new System.Drawing.Point(297, 142);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(200, 27);
            this.txtAddProductName.TabIndex = 27;
            // 
            // txtAddProductDescription
            // 
            this.txtAddProductDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAddProductDescription.Location = new System.Drawing.Point(297, 203);
            this.txtAddProductDescription.Multiline = true;
            this.txtAddProductDescription.Name = "txtAddProductDescription";
            this.txtAddProductDescription.Size = new System.Drawing.Size(281, 61);
            this.txtAddProductDescription.TabIndex = 28;
            // 
            // txtAddProductPrice
            // 
            this.txtAddProductPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAddProductPrice.Location = new System.Drawing.Point(297, 276);
            this.txtAddProductPrice.Name = "txtAddProductPrice";
            this.txtAddProductPrice.Size = new System.Drawing.Size(200, 27);
            this.txtAddProductPrice.TabIndex = 29;
            this.txtAddProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddProductPrice_KeyPress);
            // 
            // cbAddProductCategory
            // 
            this.cbAddProductCategory.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbAddProductCategory.FormattingEnabled = true;
            this.cbAddProductCategory.Location = new System.Drawing.Point(297, 333);
            this.cbAddProductCategory.Name = "cbAddProductCategory";
            this.cbAddProductCategory.Size = new System.Drawing.Size(200, 29);
            this.cbAddProductCategory.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(798, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(845, 566);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbAddProductCategory);
            this.Controls.Add(this.txtAddProductPrice);
            this.Controls.Add(this.txtAddProductDescription);
            this.Controls.Add(this.txtAddProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnAddProductClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStock";
            this.Opacity = 0.9D;
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddStock_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddProductClear;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.TextBox txtAddProductDescription;
        private System.Windows.Forms.TextBox txtAddProductPrice;
        private System.Windows.Forms.ComboBox cbAddProductCategory;
 //       private CompanyDBDataSet_Category companyDBDataSet_Category;
 //       private CompanyDBDataSet_CategoryTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}