﻿namespace MMSE_project.QuestionForms
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
            this.txtClockTime = new MMSE_project.UserControls.MandatoryTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(250, 405);
            // 
            // titleSplitter
            // 
            this.titleSplitter.Size = new System.Drawing.Size(584, 80);
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.Size = new System.Drawing.Size(584, 80);
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
            // txtClockTime
            // 
            this.txtClockTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClockTime.FieldText = "";
            this.txtClockTime.Location = new System.Drawing.Point(250, 340);
            this.txtClockTime.Name = "txtClockTime";
            this.txtClockTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClockTime.Size = new System.Drawing.Size(86, 21);
            this.txtClockTime.TabIndex = 8;
            // 
            // AnalogClockQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.txtClockTime);
            this.Controls.Add(this.pbAnalogClockImg);
            this.Name = "AnalogClockQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.pbAnalogClockImg, 0);
            this.Controls.SetChildIndex(this.txtClockTime, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnalogClockImg;
        private UserControls.MandatoryTextBox txtClockTime;
    }
}