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
            this.hoursBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.minutesBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertHour)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.Location = new System.Drawing.Point(0, 381);
            // 
            // pbConvertHour
            // 
            this.pbConvertHour.Location = new System.Drawing.Point(0, 172);
            this.pbConvertHour.Name = "pbConvertHour";
            this.pbConvertHour.Size = new System.Drawing.Size(584, 118);
            this.pbConvertHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConvertHour.TabIndex = 7;
            this.pbConvertHour.TabStop = false;
            // 
            // hoursBox
            // 
            this.hoursBox.DropDownHeight = 106;
            this.hoursBox.Location = new System.Drawing.Point(267, 314);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(150, 44);
            this.hoursBox.TabIndex = 8;
            // 
            // minutesBox
            // 
            this.minutesBox.DropDownHeight = 106;
            this.minutesBox.Location = new System.Drawing.Point(136, 314);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(150, 44);
            this.minutesBox.TabIndex = 9;
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(307, 318);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(10, 13);
            this.lblSeperator.TabIndex = 10;
            this.lblSeperator.Text = ":";
            // 
            // TimesConvertQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.pbConvertHour);
            this.Name = "TimesConvertQuestionForm";
            this.Text = "TimesConvertQuestionForm";
            this.Controls.SetChildIndex(this.pbConvertHour, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.hoursBox, 0);
            this.Controls.SetChildIndex(this.minutesBox, 0);
            this.Controls.SetChildIndex(this.lblSeperator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConvertHour;
        private MandatoryComboBox hoursBox;
        private MandatoryComboBox minutesBox;
        private System.Windows.Forms.Label lblSeperator;

    }
}