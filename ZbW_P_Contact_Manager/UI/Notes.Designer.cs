namespace ZbW_P_Contact_Manager
{
    partial class Notes
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
            LblNoteTitle = new Label();
            TxtBoxComment = new TextBox();
            FlowLayoutPanel = new FlowLayoutPanel();
            PanelTop = new Panel();
            BtnEditComment = new Button();
            BtnSave = new Button();
            PanelBottom = new Panel();
            BtnEdit = new Button();
            BtnDelete = new Button();
            ListViewHistory = new ListView();
            BtnClose = new Button();
            LblNotesHistory = new Label();
            FlowLayoutPanel.SuspendLayout();
            PanelTop.SuspendLayout();
            PanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // LblNoteTitle
            // 
            LblNoteTitle.AutoSize = true;
            LblNoteTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNoteTitle.Location = new Point(69, 49);
            LblNoteTitle.Margin = new Padding(6, 0, 6, 0);
            LblNoteTitle.Name = "LblNoteTitle";
            LblNoteTitle.Size = new Size(420, 65);
            LblNoteTitle.TabIndex = 10;
            LblNoteTitle.Text = "Notiz hinzufügen";
            // 
            // TxtBoxComment
            // 
            TxtBoxComment.BorderStyle = BorderStyle.None;
            TxtBoxComment.Location = new Point(85, 147);
            TxtBoxComment.Margin = new Padding(6, 6, 6, 6);
            TxtBoxComment.Multiline = true;
            TxtBoxComment.Name = "TxtBoxComment";
            TxtBoxComment.Size = new Size(1335, 160);
            TxtBoxComment.TabIndex = 9;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.Controls.Add(PanelTop);
            FlowLayoutPanel.Controls.Add(PanelBottom);
            FlowLayoutPanel.Location = new Point(0, -2);
            FlowLayoutPanel.Margin = new Padding(6, 4, 6, 4);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(1528, 1161);
            FlowLayoutPanel.TabIndex = 19;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(BtnEditComment);
            PanelTop.Controls.Add(LblNoteTitle);
            PanelTop.Controls.Add(BtnSave);
            PanelTop.Controls.Add(TxtBoxComment);
            PanelTop.Location = new Point(6, 4);
            PanelTop.Margin = new Padding(6, 4, 6, 4);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1525, 420);
            PanelTop.TabIndex = 27;
            // 
            // BtnEditComment
            // 
            BtnEditComment.Location = new Point(1281, 320);
            BtnEditComment.Margin = new Padding(6, 6, 6, 6);
            BtnEditComment.Name = "BtnEditComment";
            BtnEditComment.Size = new Size(139, 60);
            BtnEditComment.TabIndex = 11;
            BtnEditComment.Text = "Bearbeiten";
            BtnEditComment.UseVisualStyleBackColor = true;
            BtnEditComment.Click += BtnEditCommand_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(1281, 320);
            BtnSave.Margin = new Padding(6, 6, 6, 6);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(139, 60);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(BtnEdit);
            PanelBottom.Controls.Add(BtnDelete);
            PanelBottom.Controls.Add(ListViewHistory);
            PanelBottom.Controls.Add(BtnClose);
            PanelBottom.Controls.Add(LblNotesHistory);
            PanelBottom.Location = new Point(6, 432);
            PanelBottom.Margin = new Padding(6, 4, 6, 4);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1519, 725);
            PanelBottom.TabIndex = 28;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.Edit;
            BtnEdit.Location = new Point(1040, 640);
            BtnEdit.Margin = new Padding(6, 6, 6, 6);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(56, 64);
            BtnEdit.TabIndex = 30;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.trash_can;
            BtnDelete.Location = new Point(1107, 642);
            BtnDelete.Margin = new Padding(6, 6, 6, 6);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(56, 62);
            BtnDelete.TabIndex = 29;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // ListViewHistory
            // 
            ListViewHistory.BorderStyle = BorderStyle.None;
            ListViewHistory.FullRowSelect = true;
            ListViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewHistory.Location = new Point(85, 85);
            ListViewHistory.Margin = new Padding(6, 4, 6, 4);
            ListViewHistory.MultiSelect = false;
            ListViewHistory.Name = "ListViewHistory";
            ListViewHistory.Size = new Size(1335, 542);
            ListViewHistory.TabIndex = 27;
            ListViewHistory.UseCompatibleStateImageBehavior = false;
            ListViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(1281, 640);
            BtnClose.Margin = new Padding(6, 6, 6, 6);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(139, 62);
            BtnClose.TabIndex = 28;
            BtnClose.Text = "Schliessen";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // LblNotesHistory
            // 
            LblNotesHistory.AutoSize = true;
            LblNotesHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNotesHistory.Location = new Point(85, 32);
            LblNotesHistory.Margin = new Padding(6, 0, 6, 0);
            LblNotesHistory.Name = "LblNotesHistory";
            LblNotesHistory.Size = new Size(104, 32);
            LblNotesHistory.TabIndex = 24;
            LblNotesHistory.Text = "Notizen";
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1527, 1158);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Notes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            FlowLayoutPanel.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LblNoteTitle;
        private TextBox TxtBoxComment;
        private FlowLayoutPanel FlowLayoutPanel;
        private Label LblNotesHistory;
        private Panel PanelTop;
        private Panel PanelBottom;
        private ListView ListViewHistory;
        private Button BtnSave;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnEditComment;
    }
}