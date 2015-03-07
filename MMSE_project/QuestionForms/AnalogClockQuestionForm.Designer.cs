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
            this.txtAnalogHour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnalogClockImg
            // 
            this.pbAnalogClockImg.Location = new System.Drawing.Point(367, 86);
            this.pbAnalogClockImg.Name = "pbAnalogClockImg";
            this.pbAnalogClockImg.Size = new System.Drawing.Size(216, 208);
            this.pbAnalogClockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnalogClockImg.TabIndex = 7;
            this.pbAnalogClockImg.TabStop = false;
            // 
            // txtAnalogHour
            // 
            this.txtAnalogHour.Location = new System.Drawing.Point(431, 323);
            this.txtAnalogHour.Name = "txtAnalogHour";
            this.txtAnalogHour.Size = new System.Drawing.Size(86, 20);
            this.txtAnalogHour.TabIndex = 8;
            this.txtAnalogHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnalogClockQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.txtAnalogHour);
            this.Controls.Add(this.pbAnalogClockImg);
            this.Name = "AnalogClockQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.pbAnalogClockImg, 0);
            this.Controls.SetChildIndex(this.txtAnalogHour, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClockImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnalogClockImg;
        private System.Windows.Forms.TextBox txtAnalogHour;
    }
}