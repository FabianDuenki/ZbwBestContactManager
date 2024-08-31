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
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(356, 229);
            Panel1.TabIndex = 4;
            // 
            // FormsPlotCustomerCount
            // 
            FormsPlotCustomerCount.DisplayScale = 1F;
            FormsPlotCustomerCount.Location = new Point(27, 59);
            FormsPlotCustomerCount.Name = "FormsPlotCustomerCount";
            FormsPlotCustomerCount.Size = new Size(300, 150);
            FormsPlotCustomerCount.TabIndex = 1;
            // 
            // LblCustomerCount
            // 
            LblCustomerCount.AutoSize = true;
            LblCustomerCount.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCustomerCount.ForeColor = Color.White;
            LblCustomerCount.Location = new Point(27, 20);
            LblCustomerCount.Name = "LblCustomerCount";
            LblCustomerCount.Size = new Size(147, 25);
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
            FlowLayoutPanel.Size = new Size(733, 477);
            FlowLayoutPanel.TabIndex = 5;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(37, 42, 64);
            Panel2.Controls.Add(FormsPlotPersonTypes);
            Panel2.Controls.Add(LblPersonTypeCount);
            Panel2.Location = new Point(365, 3);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(356, 229);
            Panel2.TabIndex = 6;
            // 
            // FormsPlotPersonTypes
            // 
            FormsPlotPersonTypes.DisplayScale = 1F;
            FormsPlotPersonTypes.Location = new Point(28, 59);
            FormsPlotPersonTypes.Name = "FormsPlotPersonTypes";
            FormsPlotPersonTypes.Size = new Size(300, 150);
            FormsPlotPersonTypes.TabIndex = 2;
            // 
            // LblPersonTypeCount
            // 
            LblPersonTypeCount.AutoSize = true;
            LblPersonTypeCount.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPersonTypeCount.ForeColor = Color.White;
            LblPersonTypeCount.Location = new Point(28, 20);
            LblPersonTypeCount.Name = "LblPersonTypeCount";
            LblPersonTypeCount.Size = new Size(212, 25);
            LblPersonTypeCount.TabIndex = 2;
            LblPersonTypeCount.Text = "Abgrenzung Personen";
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(37, 42, 64);
            Panel3.Controls.Add(FormsPlotResidence);
            Panel3.Controls.Add(LblResidence);
            Panel3.Location = new Point(3, 238);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(421, 229);
            Panel3.TabIndex = 5;
            // 
            // FormsPlotResidence
            // 
            FormsPlotResidence.DisplayScale = 1F;
            FormsPlotResidence.Location = new Point(27, 57);
            FormsPlotResidence.Name = "FormsPlotResidence";
            FormsPlotResidence.Size = new Size(365, 153);
            FormsPlotResidence.TabIndex = 1;
            // 
            // LblResidence
            // 
            LblResidence.AutoSize = true;
            LblResidence.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResidence.ForeColor = Color.White;
            LblResidence.Location = new Point(27, 20);
            LblResidence.Name = "LblResidence";
            LblResidence.Size = new Size(182, 25);
            LblResidence.TabIndex = 0;
            LblResidence.Text = "Wohnort Personen";
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.FromArgb(37, 42, 64);
            Panel4.Controls.Add(LblAverage);
            Panel4.Controls.Add(FormsPlotAge);
            Panel4.Controls.Add(LblAge);
            Panel4.Location = new Point(430, 238);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(291, 229);
            Panel4.TabIndex = 6;
            // 
            // LblAverage
            // 
            LblAverage.AutoSize = true;
            LblAverage.ForeColor = SystemColors.Window;
            LblAverage.Location = new Point(27, 45);
            LblAverage.Name = "LblAverage";
            LblAverage.Size = new Size(0, 15);
            LblAverage.TabIndex = 2;
            // 
            // FormsPlotAge
            // 
            FormsPlotAge.DisplayScale = 1F;
            FormsPlotAge.Location = new Point(27, 57);
            FormsPlotAge.Name = "FormsPlotAge";
            FormsPlotAge.Size = new Size(236, 153);
            FormsPlotAge.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAge.ForeColor = Color.White;
            LblAge.Location = new Point(27, 20);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(55, 25);
            LblAge.TabIndex = 0;
            LblAge.Text = "Alter";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
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