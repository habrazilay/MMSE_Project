using MMSE_project.UserControls;
namespace MMSE_project.QuestionForms
{
    partial class NounQuestionForm
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
            this.lblThirdNoun = new System.Windows.Forms.Label();
            this.lblFirstNoun = new System.Windows.Forms.Label();
            this.lblSecondNoun = new System.Windows.Forms.Label();
            this.txtSecondNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.txtThrdNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.txtFirstNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.tlpNounsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tlpNounsPanel
            // 
            this.tlpNounsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNounsPanel.ColumnCount = 2;
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNounsPanel.Controls.Add(this.lblThirdNoun, 0, 2);
            this.tlpNounsPanel.Controls.Add(this.lblFirstNoun, 0, 0);
            this.tlpNounsPanel.Controls.Add(this.lblSecondNoun, 0, 1);
            this.tlpNounsPanel.Controls.Add(this.txtSecondNoun, 1, 1);
            this.tlpNounsPanel.Controls.Add(this.txtThrdNoun, 1, 2);
            this.tlpNounsPanel.Controls.Add(this.txtFirstNoun, 1, 0);
            this.tlpNounsPanel.Location = new System.Drawing.Point(0, 86);
            this.tlpNounsPanel.Name = "tlpNounsPanel";
            this.tlpNounsPanel.RowCount = 3;
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.Size = new System.Drawing.Size(584, 290);
            this.tlpNounsPanel.TabIndex = 6;
            // 
            // lblThirdNoun
            // 
            this.lblThirdNoun.AutoSize = true;
            this.lblThirdNoun.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblThirdNoun.Location = new System.Drawing.Point(295, 192);
            this.lblThirdNoun.Name = "lblThirdNoun";
            this.lblThirdNoun.Size = new System.Drawing.Size(102, 98);
            this.lblThirdNoun.TabIndex = 2;
            this.lblThirdNoun.Text = "שם העצם השלישי:";
            // 
            // lblFirstNoun
            // 
            this.lblFirstNoun.AutoSize = true;
            this.lblFirstNoun.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFirstNoun.Location = new System.Drawing.Point(295, 0);
            this.lblFirstNoun.Name = "lblFirstNoun";
            this.lblFirstNoun.Size = new System.Drawing.Size(100, 96);
            this.lblFirstNoun.TabIndex = 0;
            this.lblFirstNoun.Text = "שם העצם הראשון:";
            // 
            // lblSecondNoun
            // 
            this.lblSecondNoun.AutoSize = true;
            this.lblSecondNoun.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSecondNoun.Location = new System.Drawing.Point(295, 96);
            this.lblSecondNoun.Name = "lblSecondNoun";
            this.lblSecondNoun.Size = new System.Drawing.Size(86, 96);
            this.lblSecondNoun.TabIndex = 1;
            this.lblSecondNoun.Text = "שם העצם השני:";
            // 
            // txtSecondNoun
            // 
            this.txtSecondNoun.FieldText = "";
            this.txtSecondNoun.Location = new System.Drawing.Point(65, 99);
            this.txtSecondNoun.Name = "txtSecondNoun";
            this.txtSecondNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecondNoun.Size = new System.Drawing.Size(224, 24);
            this.txtSecondNoun.TabIndex = 4;
            // 
            // txtThrdNoun
            // 
            this.txtThrdNoun.FieldText = "";
            this.txtThrdNoun.Location = new System.Drawing.Point(65, 195);
            this.txtThrdNoun.Name = "txtThrdNoun";
            this.txtThrdNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThrdNoun.Size = new System.Drawing.Size(224, 24);
            this.txtThrdNoun.TabIndex = 5;
            // 
            // txtFirstNoun
            // 
            this.txtFirstNoun.FieldText = "";
            this.txtFirstNoun.Location = new System.Drawing.Point(65, 3);
            this.txtFirstNoun.Name = "txtFirstNoun";
            this.txtFirstNoun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstNoun.Size = new System.Drawing.Size(224, 21);
            this.txtFirstNoun.TabIndex = 3;
            // 
            // NounQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tlpNounsPanel);
            this.Name = "NounQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.tlpNounsPanel, 0);
            this.tlpNounsPanel.ResumeLayout(false);
            this.tlpNounsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNounsPanel;
        private System.Windows.Forms.Label lblFirstNoun;
        private System.Windows.Forms.Label lblSecondNoun;
        private System.Windows.Forms.Label lblThirdNoun;
        private MandatoryTextBox txtFirstNoun;
        private MandatoryTextBox txtThrdNoun;
        private MandatoryTextBox txtSecondNoun;
    }
}