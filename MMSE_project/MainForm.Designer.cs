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
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(182, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ברוך הבא!";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDescription.Location = new System.Drawing.Point(42, 269);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(508, 48);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "אנא הכנס את מספר תעודת הזהות שלך על מנת להתחיל\r\n במבחן סוללה נוירו-קוגניטיבית ממו" +
    "חשבת או לצפייה בהיסטוריה:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.UseCompatibleTextRendering = true;
            // 
            // pbBrain
            // 
            this.pbBrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBrain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBrain.Image = ((System.Drawing.Image)(resources.GetObject("pbBrain.Image")));
            this.pbBrain.Location = new System.Drawing.Point(190, 79);
            this.pbBrain.Name = "pbBrain";
            this.pbBrain.Size = new System.Drawing.Size(200, 187);
            this.pbBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrain.TabIndex = 2;
            this.pbBrain.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStart.Location = new System.Drawing.Point(293, 409);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStart.Size = new System.Drawing.Size(97, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "התחל!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHistory.Location = new System.Drawing.Point(190, 409);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(97, 41);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "היסטוריה";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUserID.Location = new System.Drawing.Point(190, 350);
            this.txtUserID.MaxLength = 9;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 29);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblErrorMassage
            // 
            this.lblErrorMassage.AutoSize = true;
            this.lblErrorMassage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMassage.Location = new System.Drawing.Point(179, 334);
            this.lblErrorMassage.Name = "lblErrorMassage";
            this.lblErrorMassage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblErrorMassage.Size = new System.Drawing.Size(221, 13);
            this.lblErrorMassage.TabIndex = 6;
            this.lblErrorMassage.Text = "*מספר תעודת זהות שגוי. אנא הכנס בשנית";
            this.lblErrorMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMassage.UseWaitCursor = true;
            this.lblErrorMassage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.lblErrorMassage);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbBrain);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ברוך הבא למבחן הסוללה הנוירו-קוגניטיבית הממוחשבת!";
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

