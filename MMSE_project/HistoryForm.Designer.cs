namespace MMSE_project
{
    partial class HistoryForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpHistory = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdHistory = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(244, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "היסטורית משתמש";
            // 
            // tlpHistory
            // 
            this.tlpHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHistory.ColumnCount = 1;
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHistory.Controls.Add(this.lblTitle, 0, 0);
            this.tlpHistory.Controls.Add(this.btnBack, 0, 2);
            this.tlpHistory.Controls.Add(this.grdHistory, 0, 1);
            this.tlpHistory.Location = new System.Drawing.Point(0, 1);
            this.tlpHistory.Name = "tlpHistory";
            this.tlpHistory.RowCount = 3;
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53591F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.46409F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpHistory.Size = new System.Drawing.Size(586, 267);
            this.tlpHistory.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(255, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "חזרה";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdHistory
            // 
            this.grdHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.scoreColumn,
            this.totalTimeColumn});
            this.grdHistory.Location = new System.Drawing.Point(3, 31);
            this.grdHistory.Name = "grdHistory";
            this.grdHistory.Size = new System.Drawing.Size(580, 178);
            this.grdHistory.TabIndex = 1;
            // 
            // dateColumn
            // 
            this.dateColumn.FillWeight = 200F;
            this.dateColumn.HeaderText = "תאריך";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 200;
            // 
            // scoreColumn
            // 
            this.scoreColumn.HeaderText = "ציון סופי";
            this.scoreColumn.Name = "scoreColumn";
            this.scoreColumn.ReadOnly = true;
            this.scoreColumn.Width = 180;
            // 
            // totalTimeColumn
            // 
            this.totalTimeColumn.HeaderText = "זמן כולל";
            this.totalTimeColumn.Name = "totalTimeColumn";
            this.totalTimeColumn.ReadOnly = true;
            this.totalTimeColumn.Width = 200;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.tlpHistory);
            this.Name = "HistoryForm";
            this.Text = "היסטורית תוצאות עבור משתמש";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.tlpHistory.ResumeLayout(false);
            this.tlpHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpHistory;
        private System.Windows.Forms.DataGridView grdHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeColumn;
    }
}