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
            panel1 = new Panel();
            pnlNavAdmin = new Panel();
            btnEditCustomer = new Button();
            btnCreateCustomer = new Button();
            btnEditEmployee = new Button();
            BtnCreateEmployee = new Button();
            pnlAdminFormLoader = new Panel();
            lblAdminlTitle = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 0, 54);
            panel1.Controls.Add(pnlNavAdmin);
            panel1.Controls.Add(btnEditCustomer);
            panel1.Controls.Add(btnCreateCustomer);
            panel1.Controls.Add(btnEditEmployee);
            panel1.Controls.Add(BtnCreateEmployee);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 477);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pnlNavAdmin
            // 
            pnlNavAdmin.BackColor = Color.FromArgb(0, 126, 249);
            pnlNavAdmin.Location = new Point(0, 155);
            pnlNavAdmin.Name = "pnlNavAdmin";
            pnlNavAdmin.Size = new Size(3, 100);
            pnlNavAdmin.TabIndex = 16;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Dock = DockStyle.Top;
            btnEditCustomer.FlatAppearance.BorderSize = 0;
            btnEditCustomer.FlatStyle = FlatStyle.Flat;
            btnEditCustomer.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnEditCustomer.Location = new Point(0, 126);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(186, 42);
            btnEditCustomer.TabIndex = 12;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            btnEditCustomer.Leave += btnEditCustomer_Leave;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.Dock = DockStyle.Top;
            btnCreateCustomer.FlatAppearance.BorderSize = 0;
            btnCreateCustomer.FlatStyle = FlatStyle.Flat;
            btnCreateCustomer.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnCreateCustomer.Location = new Point(0, 84);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(186, 42);
            btnCreateCustomer.TabIndex = 11;
            btnCreateCustomer.Text = "Add Customer";
            btnCreateCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            btnCreateCustomer.Leave += btnCreateCustomer_Leave;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Dock = DockStyle.Top;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEmployee.ForeColor = Color.FromArgb(0, 126, 249);
            btnEditEmployee.Location = new Point(0, 42);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(186, 42);
            btnEditEmployee.TabIndex = 10;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            btnEditEmployee.Leave += btnEditEmployee_Leave;
            // 
            // BtnCreateEmployee
            // 
            BtnCreateEmployee.Dock = DockStyle.Top;
            BtnCreateEmployee.FlatAppearance.BorderSize = 0;
            BtnCreateEmployee.FlatStyle = FlatStyle.Flat;
            BtnCreateEmployee.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreateEmployee.ForeColor = Color.FromArgb(0, 126, 249);
            BtnCreateEmployee.Location = new Point(0, 0);
            BtnCreateEmployee.Name = "BtnCreateEmployee";
            BtnCreateEmployee.Size = new Size(186, 42);
            BtnCreateEmployee.TabIndex = 9;
            BtnCreateEmployee.Text = "Add Employee";
            BtnCreateEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCreateEmployee.UseVisualStyleBackColor = true;
            BtnCreateEmployee.Click += BtnCreateEmployee_Click;
            BtnCreateEmployee.Leave += BtnCreateEmployee_Leave;
            // 
            // pnlAdminFormLoader
            // 
            pnlAdminFormLoader.Dock = DockStyle.Fill;
            pnlAdminFormLoader.Location = new Point(186, 42);
            pnlAdminFormLoader.Name = "pnlAdminFormLoader";
            pnlAdminFormLoader.Size = new Size(547, 435);
            pnlAdminFormLoader.TabIndex = 3;
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
            panel2.Controls.Add(lblAdminlTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(186, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 42);
            panel2.TabIndex = 4;
            // 
            // frmAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(pnlAdminFormLoader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdministration";
            Text = "frmAdministration";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnEditCustomer;
        private Button btnCreateCustomer;
        private Button btnEditEmployee;
        private Button BtnCreateEmployee;
        private Panel pnlAdminFormLoader;
        private Label lblAdminlTitle;
        private Panel panel2;
        private Panel pnlNavAdmin;
    }
}