namespace ModernUI
{
    partial class MainBoard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.panelPlaylistSubmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubmenu = new System.Windows.Forms.Panel();
            this.btnDeleteEmplayee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelPlaylistSubmenu.SuspendLayout();
            this.panelMediaSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubmenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnEmployee);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 516);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 471);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(250, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "Equalizer";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.UseVisualStyleBackColor = true;
            this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // panelPlaylistSubmenu
            // 
            this.panelPlaylistSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubmenu.Controls.Add(this.button5);
            this.panelPlaylistSubmenu.Controls.Add(this.button6);
            this.panelPlaylistSubmenu.Controls.Add(this.button7);
            this.panelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubmenu.Location = new System.Drawing.Point(0, 342);
            this.panelPlaylistSubmenu.Name = "panelPlaylistSubmenu";
            this.panelPlaylistSubmenu.Size = new System.Drawing.Size(250, 129);
            this.panelPlaylistSubmenu.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 80);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(0, 40);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 297);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(250, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist managment";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubmenu
            // 
            this.panelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubmenu.Controls.Add(this.btnDeleteEmplayee);
            this.panelMediaSubmenu.Controls.Add(this.btnAddEmployee);
            this.panelMediaSubmenu.Controls.Add(this.btnShowEmployee);
            this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 168);
            this.panelMediaSubmenu.Name = "panelMediaSubmenu";
            this.panelMediaSubmenu.Size = new System.Drawing.Size(250, 129);
            this.panelMediaSubmenu.TabIndex = 2;
            // 
            // btnDeleteEmplayee
            // 
            this.btnDeleteEmplayee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteEmplayee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmplayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmplayee.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteEmplayee.Location = new System.Drawing.Point(0, 80);
            this.btnDeleteEmplayee.Name = "btnDeleteEmplayee";
            this.btnDeleteEmplayee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteEmplayee.Size = new System.Drawing.Size(250, 40);
            this.btnDeleteEmplayee.TabIndex = 2;
            this.btnDeleteEmplayee.Text = "Usuń Pracownika";
            this.btnDeleteEmplayee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmplayee.UseVisualStyleBackColor = true;
            this.btnDeleteEmplayee.Click += new System.EventHandler(this.btnDeleteEmplayee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 40);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(250, 40);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Dodaj Pracownika";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowEmployee.FlatAppearance.BorderSize = 0;
            this.btnShowEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowEmployee.Size = new System.Drawing.Size(250, 40);
            this.btnShowEmployee.TabIndex = 0;
            this.btnShowEmployee.Text = "Pokaż Pracowników";
            this.btnShowEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Location = new System.Drawing.Point(0, 123);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(250, 45);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Pracownicy";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainBoard";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelPlaylistSubmenu.ResumeLayout(false);
            this.panelMediaSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistSubmenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelMediaSubmenu;
        private System.Windows.Forms.Button btnDeleteEmplayee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

