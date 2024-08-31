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
            LblNotesHistory = new Label();
            PanelTop = new Panel();
            BtnEditComment = new Button();
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
            PanelBottom.Controls.Add(LblNotesHistory);
            PanelBottom.Dock = DockStyle.Fill;
            PanelBottom.Location = new Point(3, 203);
            PanelBottom.Margin = new Padding(3, 2, 3, 2);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(768, 296);
            PanelBottom.TabIndex = 28;
            // 
            // ListViewHistory
            // 
            ListViewHistory.BackColor = Color.FromArgb(122, 148, 150);
            ListViewHistory.BorderStyle = BorderStyle.None;
            ListViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewHistory.Location = new Point(46, 40);
            ListViewHistory.Margin = new Padding(3, 2, 3, 2);
            ListViewHistory.MultiSelect = false;
            ListViewHistory.Name = "ListViewHistory";
            ListViewHistory.Size = new Size(719, 254);
            ListViewHistory.TabIndex = 27;
            ListViewHistory.UseCompatibleStateImageBehavior = false;
            ListViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // LblNotesHistory
            // 
            LblNotesHistory.AutoSize = true;
            LblNotesHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNotesHistory.Location = new Point(46, 15);
            LblNotesHistory.Name = "LblNotesHistory";
            LblNotesHistory.Size = new Size(51, 15);
            LblNotesHistory.TabIndex = 24;
            LblNotesHistory.Text = "Notizen";
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(62, 73, 76);
            PanelTop.Controls.Add(BtnEditComment);
            PanelTop.Controls.Add(LblNoteTitle);
            PanelTop.Controls.Add(BtnSave);
            PanelTop.Controls.Add(TxtBoxComment);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(3, 2);
            PanelTop.Margin = new Padding(3, 2, 3, 2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(821, 197);
            PanelTop.TabIndex = 27;
            // 
            // BtnEditComment
            // 
            BtnEditComment.Location = new Point(690, 150);
            BtnEditComment.Name = "BtnEditComment";
            BtnEditComment.Size = new Size(75, 28);
            BtnEditComment.TabIndex = 11;
            BtnEditComment.Text = "Bearbeiten";
            BtnEditComment.UseVisualStyleBackColor = true;
            // 
            // LblNoteTitle
            // 
            LblNoteTitle.AutoSize = true;
            LblNoteTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNoteTitle.Location = new Point(37, 23);
            LblNoteTitle.Name = "LblNoteTitle";
            LblNoteTitle.Size = new Size(213, 32);
            LblNoteTitle.TabIndex = 10;
            LblNoteTitle.Text = "Notiz hinzufügen";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(690, 150);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 28);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtBoxComment
            // 
            TxtBoxComment.BackColor = Color.FromArgb(122, 148, 150);
            TxtBoxComment.BorderStyle = BorderStyle.None;
            TxtBoxComment.Location = new Point(46, 69);
            TxtBoxComment.Multiline = true;
            TxtBoxComment.Name = "TxtBoxComment";
            TxtBoxComment.Size = new Size(719, 75);
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
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 73, 76);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(822, 516);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            FlowLayoutPanel.ResumeLayout(false);
            FlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBottom;
        private ListView ListViewHistory;
        private Label LblNotesHistory;
        private Panel PanelTop;
        private Button BtnEditComment;
        private Label LblNoteTitle;
        private Button BtnSave;
        private TextBox TxtBoxComment;
        private FlowLayoutPanel FlowLayoutPanel;
    }
}