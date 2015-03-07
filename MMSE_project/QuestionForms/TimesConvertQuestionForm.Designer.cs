namespace MMSE_project.QuestionForms
{
    partial class TimesConvertQuestionForm
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
            this.pbConvertHour = new System.Windows.Forms.PictureBox();
            this.txtConvertHour = new MMSE_project.UserControls.MandatoryTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertHour)).BeginInit();
            this.SuspendLayout();
            // 
            // pbConvertHour
            // 
            this.pbConvertHour.Location = new System.Drawing.Point(0, 181);
            this.pbConvertHour.Name = "pbConvertHour";
            this.pbConvertHour.Size = new System.Drawing.Size(984, 92);
            this.pbConvertHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConvertHour.TabIndex = 7;
            this.pbConvertHour.TabStop = false;
            // 
            // txtConvertHour
            // 
            this.txtConvertHour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConvertHour.FieldText = "";
            this.txtConvertHour.Location = new System.Drawing.Point(431, 331);
            this.txtConvertHour.Name = "txtConvertHour";
            this.txtConvertHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConvertHour.Size = new System.Drawing.Size(86, 21);
            this.txtConvertHour.TabIndex = 9;
            // 
            // TimesConvertQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.txtConvertHour);
            this.Controls.Add(this.pbConvertHour);
            this.Name = "TimesConvertQuestionForm";
            this.Text = "TimesConvertQuestionForm";
            this.Controls.SetChildIndex(this.pbConvertHour, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.txtConvertHour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConvertHour;
        private UserControls.MandatoryTextBox txtConvertHour;

    }
}