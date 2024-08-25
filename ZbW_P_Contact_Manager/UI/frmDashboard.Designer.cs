﻿namespace ZbW_P_Contact_Manager.UI
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
            LblDashboard3 = new Label();
            Panel1.SuspendLayout();
            FlowLayoutPanel.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
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
            Panel3.Controls.Add(LblDashboard3);
            Panel3.Location = new Point(3, 238);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(473, 229);
            Panel3.TabIndex = 5;
            // 
            // FormsPlotResidence
            // 
            FormsPlotResidence.DisplayScale = 1F;
            FormsPlotResidence.Location = new Point(27, 57);
            FormsPlotResidence.Name = "FormsPlotResidence";
            FormsPlotResidence.Size = new Size(418, 153);
            FormsPlotResidence.TabIndex = 1;
            // 
            // LblDashboard3
            // 
            LblDashboard3.AutoSize = true;
            LblDashboard3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDashboard3.ForeColor = Color.White;
            LblDashboard3.Location = new Point(27, 20);
            LblDashboard3.Name = "LblDashboard3";
            LblDashboard3.Size = new Size(221, 25);
            LblDashboard3.TabIndex = 0;
            LblDashboard3.Text = "Wohnort von Personen";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Label LblCustomerCount;
        private FlowLayoutPanel FlowLayoutPanel;
        private Panel Panel2;
        private Panel Panel3;
        private Label LblDashboard3;
        private ScottPlot.WinForms.FormsPlot FormsPlotCustomerCount;
        private ScottPlot.WinForms.FormsPlot FormsPlotPersonTypes;
        private Label LblPersonTypeCount;
        private ScottPlot.WinForms.FormsPlot FormsPlotResidence;
    }
}