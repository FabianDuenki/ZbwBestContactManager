namespace ZbW_P_Contact_Manager.UI
{
    partial class frmImportExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExport));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnImportEmployee = new Button();
            btnImportCustomer = new Button();
            btnExportEmployee = new Button();
            btnExportCustomer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(89, 35);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 2;
            label1.Text = "Import Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(435, 35);
            label2.Name = "label2";
            label2.Size = new Size(217, 37);
            label2.TabIndex = 4;
            label2.Text = "Export Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(89, 232);
            label3.Name = "label3";
            label3.Size = new Size(218, 37);
            label3.TabIndex = 5;
            label3.Text = "Import Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(435, 232);
            label4.Name = "label4";
            label4.Size = new Size(214, 37);
            label4.TabIndex = 6;
            label4.Text = "Export Customer";
            // 
            // btnImportEmployee
            // 
            btnImportEmployee.BackColor = Color.FromArgb(24, 30, 54);
            btnImportEmployee.FlatStyle = FlatStyle.Flat;
            btnImportEmployee.Image = Properties.Resources.import;
            btnImportEmployee.Location = new Point(89, 75);
            btnImportEmployee.Name = "btnImportEmployee";
            btnImportEmployee.Size = new Size(211, 138);
            btnImportEmployee.TabIndex = 12;
            btnImportEmployee.UseVisualStyleBackColor = false;
            // 
            // btnImportCustomer
            // 
            btnImportCustomer.BackColor = Color.FromArgb(24, 30, 54);
            btnImportCustomer.FlatStyle = FlatStyle.Flat;
            btnImportCustomer.Image = Properties.Resources.import;
            btnImportCustomer.Location = new Point(89, 272);
            btnImportCustomer.Name = "btnImportCustomer";
            btnImportCustomer.Size = new Size(211, 138);
            btnImportCustomer.TabIndex = 13;
            btnImportCustomer.UseVisualStyleBackColor = false;
            // 
            // btnExportEmployee
            // 
            btnExportEmployee.BackColor = Color.FromArgb(24, 30, 54);
            btnExportEmployee.FlatStyle = FlatStyle.Flat;
            btnExportEmployee.Image = Properties.Resources.database_export;
            btnExportEmployee.Location = new Point(435, 75);
            btnExportEmployee.Name = "btnExportEmployee";
            btnExportEmployee.Size = new Size(211, 138);
            btnExportEmployee.TabIndex = 14;
            btnExportEmployee.UseVisualStyleBackColor = false;
            // 
            // btnExportCustomer
            // 
            btnExportCustomer.BackColor = Color.FromArgb(24, 30, 54);
            btnExportCustomer.FlatStyle = FlatStyle.Flat;
            btnExportCustomer.Image = Properties.Resources.database_export;
            btnExportCustomer.Location = new Point(435, 272);
            btnExportCustomer.Name = "btnExportCustomer";
            btnExportCustomer.Size = new Size(211, 138);
            btnExportCustomer.TabIndex = 15;
            btnExportCustomer.UseVisualStyleBackColor = false;
            // 
            // frmImportExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(btnExportCustomer);
            Controls.Add(btnExportEmployee);
            Controls.Add(btnImportCustomer);
            Controls.Add(btnImportEmployee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmImportExport";
            Text = "frmImportExport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnImportEmployee;
        private Button btnImportCustomer;
        private Button btnExportEmployee;
        private Button btnExportCustomer;
    }
}