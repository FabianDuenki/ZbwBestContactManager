namespace ZbW_P_Contact_Manager.UI
{
    partial class frmAdministration
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
            pnlAdminFormLoader = new Panel();
            panel4 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            btnEditUser = new Button();
            btnCreateNewCustomer = new Button();
            btnRefresh = new Button();
            btnFilter = new Button();
            btnAddEmployee = new Button();
            lblAdminlTitle = new Label();
            panel2 = new Panel();
            btnTrash = new Button();
            pnlAdminFormLoader.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminFormLoader
            // 
            pnlAdminFormLoader.Controls.Add(panel4);
            pnlAdminFormLoader.Controls.Add(panel3);
            pnlAdminFormLoader.Dock = DockStyle.Fill;
            pnlAdminFormLoader.Location = new Point(0, 42);
            pnlAdminFormLoader.Name = "pnlAdminFormLoader";
            pnlAdminFormLoader.Size = new Size(733, 435);
            pnlAdminFormLoader.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 42);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(733, 393);
            panel4.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(733, 393);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 73, 76);
            panel3.Controls.Add(btnTrash);
            panel3.Controls.Add(btnEditUser);
            panel3.Controls.Add(btnCreateNewCustomer);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnFilter);
            panel3.Controls.Add(btnAddEmployee);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(733, 42);
            panel3.TabIndex = 1;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(81, 102, 105);
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Popup;
            btnEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditUser.ForeColor = Color.FromArgb(167, 177, 255);
            btnEditUser.Image = Properties.Resources.edit;
            btnEditUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditUser.Location = new Point(382, 8);
            btnEditUser.Margin = new Padding(2, 1, 2, 1);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(153, 27);
            btnEditUser.TabIndex = 4;
            btnEditUser.Text = "Edit existing User";
            btnEditUser.TextAlign = ContentAlignment.MiddleLeft;
            btnEditUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnCreateNewCustomer
            // 
            btnCreateNewCustomer.BackColor = Color.FromArgb(81, 102, 105);
            btnCreateNewCustomer.FlatAppearance.BorderSize = 0;
            btnCreateNewCustomer.FlatStyle = FlatStyle.Popup;
            btnCreateNewCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateNewCustomer.ForeColor = Color.FromArgb(167, 177, 255);
            btnCreateNewCustomer.Image = Properties.Resources.add;
            btnCreateNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateNewCustomer.Location = new Point(197, 8);
            btnCreateNewCustomer.Margin = new Padding(2, 1, 2, 1);
            btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            btnCreateNewCustomer.Size = new Size(176, 27);
            btnCreateNewCustomer.TabIndex = 3;
            btnCreateNewCustomer.Text = "Create new Customer";
            btnCreateNewCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateNewCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateNewCustomer.UseVisualStyleBackColor = false;
            btnCreateNewCustomer.Click += btnCreateNewCustomer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(694, 8);
            btnRefresh.Margin = new Padding(2, 1, 2, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 28);
            btnRefresh.TabIndex = 2;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.Transparent;
            btnFilter.Image = Properties.Resources.filter;
            btnFilter.Location = new Point(643, 8);
            btnFilter.Margin = new Padding(2, 1, 2, 1);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(32, 28);
            btnFilter.TabIndex = 1;
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(81, 102, 105);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.FromArgb(167, 177, 255);
            btnAddEmployee.Image = Properties.Resources.add;
            btnAddEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.Location = new Point(6, 8);
            btnAddEmployee.Margin = new Padding(2, 1, 2, 1);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(180, 27);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Create new Employee";
            btnAddEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblAdminlTitle
            // 
            lblAdminlTitle.AutoSize = true;
            lblAdminlTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblAdminlTitle.Location = new Point(6, 9);
            lblAdminlTitle.Name = "lblAdminlTitle";
            lblAdminlTitle.Size = new Size(190, 24);
            lblAdminlTitle.TabIndex = 1;
            lblAdminlTitle.Text = "Administration Tool";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 49, 51);
            panel2.Controls.Add(lblAdminlTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 42);
            panel2.TabIndex = 4;
            // 
            // btnTrash
            // 
            btnTrash.BackColor = Color.Transparent;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.ForeColor = Color.Transparent;
            btnTrash.Image = Properties.Resources.trash_can;
            btnTrash.Location = new Point(605, 7);
            btnTrash.Margin = new Padding(2, 1, 2, 1);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(20, 28);
            btnTrash.TabIndex = 5;
            btnTrash.UseVisualStyleBackColor = false;
            btnTrash.Click += btnTrash_Click;
            // 
            // frmAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(pnlAdminFormLoader);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdministration";
            Text = "frmAdministration";
            pnlAdminFormLoader.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlAdminFormLoader;
        private Label lblAdminlTitle;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddEmployee;
        private Panel panel4;
        private Button btnFilter;
        private Button btnRefresh;
        private Button btnCreateNewCustomer;
        private Button btnEditUser;
        private ListView listView1;
        private Button btnTrash;
    }
}