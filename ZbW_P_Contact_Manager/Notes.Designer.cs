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
            BtnSave = new Button();
            PanelBottom = new Panel();
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
            LblNoteTitle.Location = new Point(42, 31);
            LblNoteTitle.Name = "LblNoteTitle";
            LblNoteTitle.Size = new Size(263, 41);
            LblNoteTitle.TabIndex = 10;
            LblNoteTitle.Text = "Notiz hinzufügen";
            // 
            // TxtBoxComment
            // 
            TxtBoxComment.BorderStyle = BorderStyle.None;
            TxtBoxComment.Location = new Point(52, 92);
            TxtBoxComment.Margin = new Padding(3, 4, 3, 4);
            TxtBoxComment.Multiline = true;
            TxtBoxComment.Name = "TxtBoxComment";
            TxtBoxComment.Size = new Size(822, 100);
            TxtBoxComment.TabIndex = 9;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.Controls.Add(PanelTop);
            FlowLayoutPanel.Controls.Add(PanelBottom);
            FlowLayoutPanel.Location = new Point(0, -1);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(941, 725);
            FlowLayoutPanel.TabIndex = 19;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(LblNoteTitle);
            PanelTop.Controls.Add(BtnSave);
            PanelTop.Controls.Add(TxtBoxComment);
            PanelTop.Location = new Point(3, 3);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(938, 263);
            PanelTop.TabIndex = 27;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(788, 200);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(86, 31);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(ListViewHistory);
            PanelBottom.Controls.Add(BtnClose);
            PanelBottom.Controls.Add(LblNotesHistory);
            PanelBottom.Location = new Point(3, 272);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(935, 453);
            PanelBottom.TabIndex = 28;
            // 
            // ListViewHistory
            // 
            ListViewHistory.BorderStyle = BorderStyle.None;
            ListViewHistory.Location = new Point(52, 54);
            ListViewHistory.Name = "ListViewHistory";
            ListViewHistory.Size = new Size(822, 339);
            ListViewHistory.TabIndex = 27;
            ListViewHistory.UseCompatibleStateImageBehavior = false;
            ListViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(788, 400);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(86, 31);
            BtnClose.TabIndex = 28;
            BtnClose.Text = "Schliessen";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // LblNotesHistory
            // 
            LblNotesHistory.AutoSize = true;
            LblNotesHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNotesHistory.Location = new Point(52, 20);
            LblNotesHistory.Name = "LblNotesHistory";
            LblNotesHistory.Size = new Size(64, 20);
            LblNotesHistory.TabIndex = 24;
            LblNotesHistory.Text = "Notizen";
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(939, 724);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button CmdSave;
        private FlowLayoutPanel FlowLayoutPanel;
        private Label LblNotesHistory;
        private Panel PanelTop;
        private Panel PanelBottom;
        private ListView ListViewHistory;
        private Button BtnSave;
        private Button BtnClose;
    }
}