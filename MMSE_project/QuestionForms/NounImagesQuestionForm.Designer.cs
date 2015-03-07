
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
            this.txtFirstNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.pbSecondNounImage = new System.Windows.Forms.PictureBox();
            this.pbThirdNounImage = new System.Windows.Forms.PictureBox();
            this.pbFirstNounImage = new System.Windows.Forms.PictureBox();
            this.tlpNounsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondNounImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdNounImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstNounImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(431, 404);
            // 
            // tlpNounsPanel
            // 
            this.tlpNounsPanel.ColumnCount = 4;
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tlpNounsPanel.Controls.Add(this.txtThrdNoun, 2, 2);
            this.tlpNounsPanel.Controls.Add(this.txtSecondNoun, 2, 1);
            this.tlpNounsPanel.Controls.Add(this.pbSecondNounImage, 1, 1);
            this.tlpNounsPanel.Controls.Add(this.pbThirdNounImage, 1, 2);
            this.tlpNounsPanel.Controls.Add(this.pbFirstNounImage, 1, 0);
            this.tlpNounsPanel.Controls.Add(this.txtFirstNoun, 2, 0);
            this.tlpNounsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNounsPanel.Location = new System.Drawing.Point(0, 80);
            this.tlpNounsPanel.Name = "tlpNounsPanel";
            this.tlpNounsPanel.RowCount = 3;
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.Size = new System.Drawing.Size(984, 301);
            this.tlpNounsPanel.TabIndex = 7;
            // 
            // txtThrdNoun
            // 
            this.txtThrdNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThrdNoun.FieldText = "";
            this.txtThrdNoun.Location = new System.Drawing.Point(485, 239);
            this.txtThrdNoun.Name = "txtThrdNoun";
            this.txtThrdNoun.Size = new System.Drawing.Size(223, 23);
            this.txtThrdNoun.TabIndex = 5;
            // 
            // txtSecondNoun
            // 
            this.txtSecondNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSecondNoun.FieldText = "";
            this.txtSecondNoun.Location = new System.Drawing.Point(485, 139);
            this.txtSecondNoun.Name = "txtSecondNoun";
            this.txtSecondNoun.Size = new System.Drawing.Size(223, 22);
            this.txtSecondNoun.TabIndex = 4;
            // 
            // txtFirstNoun
            // 
            this.txtFirstNoun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstNoun.FieldText = "";
            this.txtFirstNoun.Location = new System.Drawing.Point(485, 39);
            this.txtFirstNoun.Name = "txtFirstNoun";
            this.txtFirstNoun.Size = new System.Drawing.Size(223, 21);
            this.txtFirstNoun.TabIndex = 3;
            // 
            // pbSecondNounImage
            // 
            this.pbSecondNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSecondNounImage.Image = global::MMSE_project.Properties.Resources.cat;
            this.pbSecondNounImage.Location = new System.Drawing.Point(354, 103);
            this.pbSecondNounImage.Name = "pbSecondNounImage";
            this.pbSecondNounImage.Size = new System.Drawing.Size(125, 94);
            this.pbSecondNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondNounImage.TabIndex = 7;
            this.pbSecondNounImage.TabStop = false;
            // 
            // pbThirdNounImage
            // 
            this.pbThirdNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbThirdNounImage.Image = global::MMSE_project.Properties.Resources.car;
            this.pbThirdNounImage.Location = new System.Drawing.Point(354, 203);
            this.pbThirdNounImage.Name = "pbThirdNounImage";
            this.pbThirdNounImage.Size = new System.Drawing.Size(125, 95);
            this.pbThirdNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThirdNounImage.TabIndex = 8;
            this.pbThirdNounImage.TabStop = false;
            // 
            // pbFirstNounImage
            // 
            this.pbFirstNounImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbFirstNounImage.Image = global::MMSE_project.Properties.Resources.sun;
            this.pbFirstNounImage.Location = new System.Drawing.Point(354, 3);
            this.pbFirstNounImage.Name = "pbFirstNounImage";
            this.pbFirstNounImage.Size = new System.Drawing.Size(125, 94);
            this.pbFirstNounImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstNounImage.TabIndex = 6;
            this.pbFirstNounImage.TabStop = false;
            // 
            // NounImagesQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tlpNounsPanel);
            this.Name = "NounImagesQuestionForm";
            this.Text = "NounImagesQuestionForm";
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
        private UserControls.MandatoryTextBox txtThrdNoun;
        private UserControls.MandatoryTextBox txtSecondNoun;
        private UserControls.MandatoryTextBox txtFirstNoun;
        private System.Windows.Forms.PictureBox pbFirstNounImage;
        private System.Windows.Forms.PictureBox pbSecondNounImage;
        private System.Windows.Forms.PictureBox pbThirdNounImage;

    }
}