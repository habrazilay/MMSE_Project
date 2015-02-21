namespace MMSE_project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbBrain = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblErrorMassage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(237, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome!";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(114, 309);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(455, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "To start the Computerized Neurocognitive Battery or watch history, please enter y" +
    "ou ID number:";
            // 
            // pbBrain
            // 
            this.pbBrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBrain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBrain.Image = ((System.Drawing.Image)(resources.GetObject("pbBrain.Image")));
            this.pbBrain.Location = new System.Drawing.Point(245, 103);
            this.pbBrain.Name = "pbBrain";
            this.pbBrain.Size = new System.Drawing.Size(219, 187);
            this.pbBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrain.TabIndex = 2;
            this.pbBrain.TabStop = false;
            this.pbBrain.Click += new System.EventHandler(this.pbBrain_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(267, 378);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(359, 378);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(302, 352);
            this.txtUserID.MaxLength = 9;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblErrorMassage
            // 
            this.lblErrorMassage.AutoSize = true;
            this.lblErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMassage.Location = new System.Drawing.Point(249, 336);
            this.lblErrorMassage.Name = "lblErrorMassage";
            this.lblErrorMassage.Size = new System.Drawing.Size(228, 13);
            this.lblErrorMassage.TabIndex = 6;
            this.lblErrorMassage.Text = "* ID number is incorrect. Please enter ID again.";
            this.lblErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMassage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(742, 413);
            this.Controls.Add(this.lblErrorMassage);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbBrain);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computerized Neurocognitive Battery (CNB)";
            ((System.ComponentModel.ISupportInitialize)(this.pbBrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbBrain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblErrorMassage;
    }
}

