namespace MMSE_project.QuestionForms
{
    partial class AnalogClockQuestionForm
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
            this.pbAnalogClockImg = new System.Windows.Forms.PictureBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.minutesBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.hoursBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnalogClockImg
            // 
            this.pbAnalogClockImg.Location = new System.Drawing.Point(165, 109);
            this.pbAnalogClockImg.Name = "pbAnalogClockImg";
            this.pbAnalogClockImg.Size = new System.Drawing.Size(216, 208);
            this.pbAnalogClockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnalogClockImg.TabIndex = 7;
            this.pbAnalogClockImg.TabStop = false;
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(265, 336);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(10, 13);
            this.lblSeperator.TabIndex = 13;
            this.lblSeperator.Text = ":";
            // 
            // minutesBox
            // 
            this.minutesBox.DropDownHeight = 106;
            this.minutesBox.Location = new System.Drawing.Point(90, 336);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(150, 44);
            this.minutesBox.TabIndex = 12;
            // 
            // hoursBox
            // 
            this.hoursBox.DropDownHeight = 106;
            this.hoursBox.Location = new System.Drawing.Point(231, 336);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(150, 44);
            this.hoursBox.TabIndex = 11;
            // 
            // AnalogClockQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.pbAnalogClockImg);
            this.Name = "AnalogClockQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.pbAnalogClockImg, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.hoursBox, 0);
            this.Controls.SetChildIndex(this.minutesBox, 0);
            this.Controls.SetChildIndex(this.lblSeperator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnalogClockImg;
        private System.Windows.Forms.Label lblSeperator;
        private MandatoryComboBox minutesBox;
        private MandatoryComboBox hoursBox;
    }
}