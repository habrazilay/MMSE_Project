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
            this.cmbHours = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.cmbMinutes = new MMSE_project.QuestionForms.MandatoryComboBox();
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
            this.pbConvertHour.Image = global::MMSE_project.Properties.Resources.h0030;
            this.pbConvertHour.Location = new System.Drawing.Point(0, 172);
            this.pbConvertHour.Name = "pbConvertHour";
            this.pbConvertHour.Size = new System.Drawing.Size(584, 118);
            this.pbConvertHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConvertHour.TabIndex = 7;
            this.pbConvertHour.TabStop = false;
            // 
            // cmbHours
            // 
            this.cmbHours.DropDownHeight = 106;
            this.cmbHours.Location = new System.Drawing.Point(267, 314);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(150, 44);
            this.cmbHours.TabIndex = 8;
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.DropDownHeight = 106;
            this.cmbMinutes.Location = new System.Drawing.Point(136, 314);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(150, 44);
            this.cmbMinutes.TabIndex = 9;
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
            this.Controls.Add(this.cmbMinutes);
            this.Controls.Add(this.cmbHours);
            this.Controls.Add(this.pbConvertHour);
            this.Name = "TimesConvertQuestionForm";
            this.Text = "TimesConvertQuestionForm";
            this.Controls.SetChildIndex(this.pbConvertHour, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.cmbHours, 0);
            this.Controls.SetChildIndex(this.cmbMinutes, 0);
            this.Controls.SetChildIndex(this.lblSeperator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConvertHour;
        private MandatoryComboBox cmbHours;
        private MandatoryComboBox cmbMinutes;
        private System.Windows.Forms.Label lblSeperator;

    }
}