namespace ZbW_P_Contact_Manager.UI
{
    partial class Administration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnCreateNewEmployee = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Administration";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.Location = new Point(29, 74);
            btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            btnCreateNewEmployee.Size = new Size(125, 23);
            btnCreateNewEmployee.TabIndex = 1;
            btnCreateNewEmployee.Text = "CreateNewEmployee";
            btnCreateNewEmployee.UseVisualStyleBackColor = true;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateNewEmployee);
            Controls.Add(textBox1);
            Name = "Administration";
            Size = new Size(990, 651);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnCreateNewEmployee;
    }
}
