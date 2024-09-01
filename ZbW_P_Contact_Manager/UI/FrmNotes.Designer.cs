namespace ZbW_P_Contact_Manager
{
    partial class FrmNotes
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
            PanelBottom = new Panel();
            ListViewHistory = new ListView();
            PanelTop = new Panel();
            LblNoteTitle = new Label();
            BtnSave = new Button();
            TxtBoxComment = new TextBox();
            FlowLayoutPanel = new FlowLayoutPanel();
            PanelBottom.SuspendLayout();
            PanelTop.SuspendLayout();
            FlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBottom
            // 
            PanelBottom.AutoSize = true;
            PanelBottom.BackColor = Color.FromArgb(62, 73, 76);
            PanelBottom.Controls.Add(ListViewHistory);
            PanelBottom.Dock = DockStyle.Fill;
            PanelBottom.Location = new Point(3, 243);
            PanelBottom.Margin = new Padding(3, 2, 3, 2);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(768, 226);
            PanelBottom.TabIndex = 28;
            // 
            // ListViewHistory
            // 
            ListViewHistory.BackColor = Color.FromArgb(37, 42, 64);
            ListViewHistory.BorderStyle = BorderStyle.None;
            ListViewHistory.ForeColor = SystemColors.Window;
            ListViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewHistory.HideSelection = true;
            ListViewHistory.Location = new Point(46, 44);
            ListViewHistory.Margin = new Padding(3, 2, 3, 2);
            ListViewHistory.MultiSelect = false;
            ListViewHistory.Name = "ListViewHistory";
            ListViewHistory.Size = new Size(719, 180);
            ListViewHistory.TabIndex = 27;
            ListViewHistory.UseCompatibleStateImageBehavior = false;
            ListViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(62, 73, 76);
            PanelTop.Controls.Add(LblNoteTitle);
            PanelTop.Controls.Add(BtnSave);
            PanelTop.Controls.Add(TxtBoxComment);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(3, 2);
            PanelTop.Margin = new Padding(3, 2, 3, 2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(821, 237);
            PanelTop.TabIndex = 27;
            // 
            // LblNoteTitle
            // 
            LblNoteTitle.AutoSize = true;
            LblNoteTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNoteTitle.ForeColor = SystemColors.Window;
            LblNoteTitle.Location = new Point(37, 23);
            LblNoteTitle.Name = "LblNoteTitle";
            LblNoteTitle.Size = new Size(213, 32);
            LblNoteTitle.TabIndex = 10;
            LblNoteTitle.Text = "Notiz hinzufügen";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(693, 196);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 28);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtBoxComment
            // 
            TxtBoxComment.BackColor = Color.FromArgb(37, 42, 64);
            TxtBoxComment.BorderStyle = BorderStyle.None;
            TxtBoxComment.ForeColor = SystemColors.Window;
            TxtBoxComment.Location = new Point(46, 69);
            TxtBoxComment.Multiline = true;
            TxtBoxComment.Name = "TxtBoxComment";
            TxtBoxComment.Size = new Size(719, 121);
            TxtBoxComment.TabIndex = 9;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = Color.FromArgb(62, 73, 76);
            FlowLayoutPanel.Controls.Add(PanelTop);
            FlowLayoutPanel.Controls.Add(PanelBottom);
            FlowLayoutPanel.Dock = DockStyle.Fill;
            FlowLayoutPanel.Location = new Point(0, 0);
            FlowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(822, 516);
            FlowLayoutPanel.TabIndex = 19;
            // 
            // FrmNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 73, 76);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(822, 516);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            PanelBottom.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            FlowLayoutPanel.ResumeLayout(false);
            FlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBottom;
        private ListView ListViewHistory;
        private Panel PanelTop;
        private Label LblNoteTitle;
        private Button BtnSave;
        private TextBox TxtBoxComment;
        private FlowLayoutPanel FlowLayoutPanel;
    }
}