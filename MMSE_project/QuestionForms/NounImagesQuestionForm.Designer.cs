
namespace MMSE_project.QuestionForms
{
    partial class NounImagesQuestionForm
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
            this.tlpNounsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtThrdNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.txtSecondNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.pbSecondNounImage = new System.Windows.Forms.PictureBox();
            this.pbThirdNounImage = new System.Windows.Forms.PictureBox();
            this.pbFirstNounImage = new System.Windows.Forms.PictureBox();
            this.txtFirstNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.tlpNounsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondNounImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdNounImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstNounImage)).BeginInit();
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
            // tlpNounsPanel
            // 
            this.tlpNounsPanel.ColumnCount = 2;
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNounsPanel.Controls.Add(this.txtThrdNoun, 1, 2);
            this.tlpNounsPanel.Controls.Add(this.txtSecondNoun, 1, 1);
            this.tlpNounsPanel.Controls.Add(this.pbSecondNounImage, 0, 1);
            this.tlpNounsPanel.Controls.Add(this.pbThirdNounImage, 0, 2);
            this.tlpNounsPanel.Controls.Add(this.pbFirstNounImage, 0, 0);
            this.tlpNounsPanel.Controls.Add(this.txtFirstNoun, 1, 0);
            this.tlpNounsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNounsPanel.Location = new System.Drawing.Point(0, 80);
            this.tlpNounsPanel.Name = "tlpNounsPanel";
            this.tlpNounsPanel.RowCount = 3;
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.Size = new System.Drawing.Size(584, 302);
            this.tlpNounsPanel.TabIndex = 7;
            // 
            // txtThrdNoun
            // 
            this.txtThrdNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThrdNoun.FieldText = "";
            this.txtThrdNoun.Location = new System.Drawing.Point(66, 239);
            this.txtThrdNoun.Name = "txtThrdNoun";
            this.txtThrdNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThrdNoun.Size = new System.Drawing.Size(223, 23);
            this.txtThrdNoun.TabIndex = 5;
            // 
            // txtSecondNoun
            // 
            this.txtSecondNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSecondNoun.FieldText = "";
            this.txtSecondNoun.Location = new System.Drawing.Point(66, 139);
            this.txtSecondNoun.Name = "txtSecondNoun";
            this.txtSecondNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecondNoun.Size = new System.Drawing.Size(223, 22);
            this.txtSecondNoun.TabIndex = 4;
            // 
            // pbSecondNounImage
            // 
            this.pbSecondNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSecondNounImage.Location = new System.Drawing.Point(295, 103);
            this.pbSecondNounImage.Name = "pbSecondNounImage";
            this.pbSecondNounImage.Size = new System.Drawing.Size(125, 94);
            this.pbSecondNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondNounImage.TabIndex = 7;
            this.pbSecondNounImage.TabStop = false;
            // 
            // pbThirdNounImage
            // 
            this.pbThirdNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbThirdNounImage.Location = new System.Drawing.Point(295, 203);
            this.pbThirdNounImage.Name = "pbThirdNounImage";
            this.pbThirdNounImage.Size = new System.Drawing.Size(125, 96);
            this.pbThirdNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThirdNounImage.TabIndex = 8;
            this.pbThirdNounImage.TabStop = false;
            // 
            // pbFirstNounImage
            // 
            this.pbFirstNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbFirstNounImage.Location = new System.Drawing.Point(295, 3);
            this.pbFirstNounImage.Name = "pbFirstNounImage";
            this.pbFirstNounImage.Size = new System.Drawing.Size(125, 94);
            this.pbFirstNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstNounImage.TabIndex = 6;
            this.pbFirstNounImage.TabStop = false;
            // 
            // txtFirstNoun
            // 
            this.txtFirstNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstNoun.FieldText = "";
            this.txtFirstNoun.Location = new System.Drawing.Point(66, 39);
            this.txtFirstNoun.Name = "txtFirstNoun";
            this.txtFirstNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstNoun.Size = new System.Drawing.Size(223, 21);
            this.txtFirstNoun.TabIndex = 3;
            // 
            // NounImagesQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tlpNounsPanel);
            this.Name = "NounImagesQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.tlpNounsPanel, 0);
            this.tlpNounsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondNounImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdNounImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstNounImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNounsPanel;
        private System.Windows.Forms.PictureBox pbFirstNounImage;
        private System.Windows.Forms.PictureBox pbSecondNounImage;
        private UserControls.MandatoryTextBox txtThrdNoun;
        private UserControls.MandatoryTextBox txtSecondNoun;
        private System.Windows.Forms.PictureBox pbThirdNounImage;
        private UserControls.MandatoryTextBox txtFirstNoun;

    }
}