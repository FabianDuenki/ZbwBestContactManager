namespace ZbW_P_Contact_Manager.UI
{
    partial class FrmDashboard
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
            Panel1 = new Panel();
            FormsPlotCustomerCount = new ScottPlot.WinForms.FormsPlot();
            LblCustomerCount = new Label();
            FlowLayoutPanel = new FlowLayoutPanel();
            Panel2 = new Panel();
            FormsPlotPersonTypes = new ScottPlot.WinForms.FormsPlot();
            LblPersonTypeCount = new Label();
            Panel3 = new Panel();
            FormsPlotResidence = new ScottPlot.WinForms.FormsPlot();
            LblResidence = new Label();
            Panel4 = new Panel();
            LblAverage = new Label();
            FormsPlotAge = new ScottPlot.WinForms.FormsPlot();
            LblAge = new Label();
            Panel1.SuspendLayout();
            FlowLayoutPanel.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            Panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(37, 42, 64);
            Panel1.Controls.Add(FormsPlotCustomerCount);
            Panel1.Controls.Add(LblCustomerCount);
            Panel1.Location = new Point(3, 4);
            Panel1.Margin = new Padding(3, 4, 3, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(407, 305);
            Panel1.TabIndex = 4;
            // 
            // FormsPlotCustomerCount
            // 
            FormsPlotCustomerCount.DisplayScale = 1F;
            FormsPlotCustomerCount.Location = new Point(31, 79);
            FormsPlotCustomerCount.Margin = new Padding(3, 4, 3, 4);
            FormsPlotCustomerCount.Name = "FormsPlotCustomerCount";
            FormsPlotCustomerCount.Size = new Size(343, 200);
            FormsPlotCustomerCount.TabIndex = 1;
            // 
            // LblCustomerCount
            // 
            LblCustomerCount.AutoSize = true;
            LblCustomerCount.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCustomerCount.ForeColor = Color.White;
            LblCustomerCount.Location = new Point(31, 27);
            LblCustomerCount.Name = "LblCustomerCount";
            LblCustomerCount.Size = new Size(188, 32);
            LblCustomerCount.TabIndex = 0;
            LblCustomerCount.Text = "Anzahl Kunden";
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = Color.FromArgb(62, 73, 76);
            FlowLayoutPanel.Controls.Add(Panel1);
            FlowLayoutPanel.Controls.Add(Panel2);
            FlowLayoutPanel.Controls.Add(Panel3);
            FlowLayoutPanel.Controls.Add(Panel4);
            FlowLayoutPanel.Dock = DockStyle.Fill;
            FlowLayoutPanel.Location = new Point(0, 0);
            FlowLayoutPanel.Margin = new Padding(2, 1, 2, 1);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(838, 636);
            FlowLayoutPanel.TabIndex = 5;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(37, 42, 64);
            Panel2.Controls.Add(FormsPlotPersonTypes);
            Panel2.Controls.Add(LblPersonTypeCount);
            Panel2.Location = new Point(416, 4);
            Panel2.Margin = new Padding(3, 4, 3, 4);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(407, 305);
            Panel2.TabIndex = 6;
            // 
            // FormsPlotPersonTypes
            // 
            FormsPlotPersonTypes.DisplayScale = 1F;
            FormsPlotPersonTypes.Location = new Point(32, 79);
            FormsPlotPersonTypes.Margin = new Padding(3, 4, 3, 4);
            FormsPlotPersonTypes.Name = "FormsPlotPersonTypes";
            FormsPlotPersonTypes.Size = new Size(343, 200);
            FormsPlotPersonTypes.TabIndex = 2;
            // 
            // LblPersonTypeCount
            // 
            LblPersonTypeCount.AutoSize = true;
            LblPersonTypeCount.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPersonTypeCount.ForeColor = Color.White;
            LblPersonTypeCount.Location = new Point(32, 27);
            LblPersonTypeCount.Name = "LblPersonTypeCount";
            LblPersonTypeCount.Size = new Size(269, 32);
            LblPersonTypeCount.TabIndex = 2;
            LblPersonTypeCount.Text = "Abgrenzung Personen";
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(37, 42, 64);
            Panel3.Controls.Add(FormsPlotResidence);
            Panel3.Controls.Add(LblResidence);
            Panel3.Location = new Point(3, 317);
            Panel3.Margin = new Padding(3, 4, 3, 4);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(481, 305);
            Panel3.TabIndex = 5;
            // 
            // FormsPlotResidence
            // 
            FormsPlotResidence.DisplayScale = 1F;
            FormsPlotResidence.Location = new Point(31, 76);
            FormsPlotResidence.Margin = new Padding(3, 4, 3, 4);
            FormsPlotResidence.Name = "FormsPlotResidence";
            FormsPlotResidence.Size = new Size(417, 204);
            FormsPlotResidence.TabIndex = 1;
            // 
            // LblResidence
            // 
            LblResidence.AutoSize = true;
            LblResidence.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResidence.ForeColor = Color.White;
            LblResidence.Location = new Point(31, 27);
            LblResidence.Name = "LblResidence";
            LblResidence.Size = new Size(279, 32);
            LblResidence.TabIndex = 0;
            LblResidence.Text = "Wohnort von Personen";
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.FromArgb(37, 42, 64);
            Panel4.Controls.Add(LblAverage);
            Panel4.Controls.Add(FormsPlotAge);
            Panel4.Controls.Add(LblAge);
            Panel4.Location = new Point(490, 317);
            Panel4.Margin = new Padding(3, 4, 3, 4);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(333, 305);
            Panel4.TabIndex = 6;
            // 
            // LblAverage
            // 
            LblAverage.AutoSize = true;
            LblAverage.ForeColor = SystemColors.Window;
            LblAverage.Location = new Point(31, 60);
            LblAverage.Name = "LblAverage";
            LblAverage.Size = new Size(0, 20);
            LblAverage.TabIndex = 2;
            // 
            // FormsPlotAge
            // 
            FormsPlotAge.DisplayScale = 1F;
            FormsPlotAge.Location = new Point(31, 76);
            FormsPlotAge.Margin = new Padding(3, 4, 3, 4);
            FormsPlotAge.Name = "FormsPlotAge";
            FormsPlotAge.Size = new Size(270, 204);
            FormsPlotAge.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAge.ForeColor = Color.White;
            LblAge.Location = new Point(31, 27);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(70, 32);
            LblAge.TabIndex = 0;
            LblAge.Text = "Alter";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(838, 636);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDashboard";
            Text = " ";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            FlowLayoutPanel.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Label LblCustomerCount;
        private FlowLayoutPanel FlowLayoutPanel;
        private Panel Panel2;
        private Panel Panel3;
        private Label LblResidence;
        private ScottPlot.WinForms.FormsPlot FormsPlotCustomerCount;
        private ScottPlot.WinForms.FormsPlot FormsPlotPersonTypes;
        private Label LblPersonTypeCount;
        private ScottPlot.WinForms.FormsPlot FormsPlotResidence;
        private Panel Panel4;
        private ScottPlot.WinForms.FormsPlot FormsPlotAge;
        private Label LblAge;
        private Label LblAverage;
    }
}