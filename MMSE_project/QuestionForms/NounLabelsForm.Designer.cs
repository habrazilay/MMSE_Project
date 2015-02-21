namespace MMSE_project.QuestionForms
{
    partial class NounLabelsForm
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
            this.components = new System.ComponentModel.Container();
            this.titleSplitter = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.wordsTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlNoun = new System.Windows.Forms.Panel();
            this.lblNoun = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.pnlNoun.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleSplitter
            // 
            this.titleSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleSplitter.Location = new System.Drawing.Point(0, 0);
            this.titleSplitter.Name = "titleSplitter";
            this.titleSplitter.Size = new System.Drawing.Size(984, 80);
            this.titleSplitter.TabIndex = 4;
            this.titleSplitter.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(463, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Question Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordsTimer
            // 
            this.wordsTimer.Interval = 10000;
            this.wordsTimer.Tick += new System.EventHandler(this.wordsTimer_Tick);
            // 
            // pnlNoun
            // 
            this.pnlNoun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNoun.Controls.Add(this.lblNoun);
            this.pnlNoun.Location = new System.Drawing.Point(0, 86);
            this.pnlNoun.Name = "pnlNoun";
            this.pnlNoun.Size = new System.Drawing.Size(984, 376);
            this.pnlNoun.TabIndex = 6;
            // 
            // lblNoun
            // 
            this.lblNoun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNoun.AutoSize = true;
            this.lblNoun.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNoun.Location = new System.Drawing.Point(405, 158);
            this.lblNoun.Name = "lblNoun";
            this.lblNoun.Size = new System.Drawing.Size(224, 73);
            this.lblNoun.TabIndex = 0;
            this.lblNoun.Text = "NOUN";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(463, 47);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(72, 13);
            this.lblTimeLeft.TabIndex = 7;
            this.lblTimeLeft.Text = "Question Title";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NounLabelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.pnlNoun);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.titleSplitter);
            this.Name = "NounLabelsForm";
            this.Text = "NounQuestionForm";
            this.pnlNoun.ResumeLayout(false);
            this.pnlNoun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Splitter titleSplitter;
        protected System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer wordsTimer;
        private System.Windows.Forms.Panel pnlNoun;
        private System.Windows.Forms.Label lblNoun;
        protected System.Windows.Forms.Label lblTimeLeft;
    }
}