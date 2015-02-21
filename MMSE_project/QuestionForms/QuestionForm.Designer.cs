namespace MMSE_project
{
    partial class QuestionForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.titleSplitter = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.buttonSplitter = new System.Windows.Forms.Splitter();
            this.lblPartNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(431, 405);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 27);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // titleSplitter
            // 
            this.titleSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleSplitter.Location = new System.Drawing.Point(0, 0);
            this.titleSplitter.Name = "titleSplitter";
            this.titleSplitter.Size = new System.Drawing.Size(984, 80);
            this.titleSplitter.TabIndex = 3;
            this.titleSplitter.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(469, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Question Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSplitter.Location = new System.Drawing.Point(0, 382);
            this.buttonSplitter.Name = "buttonSplitter";
            this.buttonSplitter.Size = new System.Drawing.Size(984, 80);
            this.buttonSplitter.TabIndex = 5;
            this.buttonSplitter.TabStop = false;
            // 
            // lblPartNum
            // 
            this.lblPartNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartNum.AutoSize = true;
            this.lblPartNum.Location = new System.Drawing.Point(469, 20);
            this.lblPartNum.Name = "lblPartNum";
            this.lblPartNum.Size = new System.Drawing.Size(26, 13);
            this.lblPartNum.TabIndex = 6;
            this.lblPartNum.Text = "Part";
            this.lblPartNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.lblPartNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.buttonSplitter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.titleSplitter);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnNext;
        protected System.Windows.Forms.Splitter titleSplitter;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Splitter buttonSplitter;
        protected System.Windows.Forms.Label lblPartNum;
    }
}