namespace ZbW_P_Contact_Manager.UI
{
    partial class Main
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
            btnHome = new Button();
            btnHistory = new Button();
            btnImportExport = new Button();
            btnSearch = new Button();
            btnCustomerContact = new Button();
            btnAdministration = new Button();
            history1 = new History();
            importExport1 = new ImportExport();
            search1 = new Search();
            customerContact1 = new CustomerContact();
            administration1 = new Administration();
            home1 = new Home();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnImportExport);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnCustomerContact);
            panel1.Controls.Add(btnAdministration);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 450);
            panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(3, 7);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(145, 36);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click_1;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(3, 217);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(145, 36);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnImportExport
            // 
            btnImportExport.Location = new Point(3, 175);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Size = new Size(145, 36);
            btnImportExport.TabIndex = 4;
            btnImportExport.Text = "Import/Export";
            btnImportExport.UseVisualStyleBackColor = true;
            btnImportExport.Click += btnImportExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(145, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCustomerContact
            // 
            btnCustomerContact.Location = new Point(3, 91);
            btnCustomerContact.Name = "btnCustomerContact";
            btnCustomerContact.Size = new Size(145, 36);
            btnCustomerContact.TabIndex = 2;
            btnCustomerContact.Text = "CustomerContact";
            btnCustomerContact.UseVisualStyleBackColor = true;
            btnCustomerContact.Click += btnCustomerContact_Click;
            // 
            // btnAdministration
            // 
            btnAdministration.Location = new Point(3, 49);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(145, 36);
            btnAdministration.TabIndex = 1;
            btnAdministration.Text = "Administration";
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            // 
            // history1
            // 
            history1.Location = new Point(152, 0);
            history1.Name = "history1";
            history1.Size = new Size(648, 450);
            history1.TabIndex = 2;
            // 
            // importExport1
            // 
            importExport1.Location = new Point(152, 0);
            importExport1.Name = "importExport1";
            importExport1.Size = new Size(648, 450);
            importExport1.TabIndex = 3;
            // 
            // search1
            // 
            search1.Location = new Point(152, 0);
            search1.Name = "search1";
            search1.Size = new Size(648, 450);
            search1.TabIndex = 4;
            // 
            // customerContact1
            // 
            customerContact1.Location = new Point(152, 0);
            customerContact1.Name = "customerContact1";
            customerContact1.Size = new Size(648, 450);
            customerContact1.TabIndex = 5;
            // 
            // administration1
            // 
            administration1.Location = new Point(152, 0);
            administration1.Name = "administration1";
            administration1.Size = new Size(648, 450);
            administration1.TabIndex = 6;
            // 
            // home1
            // 
            home1.Location = new Point(152, 0);
            home1.Name = "home1";
            home1.Size = new Size(648, 450);
            home1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home1);
            Controls.Add(administration1);
            Controls.Add(customerContact1);
            Controls.Add(search1);
            Controls.Add(importExport1);
            Controls.Add(history1);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnImportExport;
        private Button btnSearch;
        private Button btnCustomerContact;
        private Button btnAdministration;
        private Button btnHistory;
        private History history1;
        private ImportExport importExport1;
        private Search search1;
        private CustomerContact customerContact1;
        private Administration administration1;
        private Home home1;
        private Button btnHome;
    }
}