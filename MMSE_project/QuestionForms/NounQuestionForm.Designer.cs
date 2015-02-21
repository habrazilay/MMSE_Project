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
            this.txtThrdNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.txtSecondNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.lblFirstNoun = new System.Windows.Forms.Label();
            this.lblSecondNoun = new System.Windows.Forms.Label();
            this.lblThirdNoun = new System.Windows.Forms.Label();
            this.txtFirstNoun = new MMSE_project.UserControls.MandatoryTextBox();
            this.tlpNounsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(431, 404);
            // 
            // tlpNounsPanel
            // 
            this.tlpNounsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNounsPanel.ColumnCount = 4;
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNounsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNounsPanel.Controls.Add(this.txtThrdNoun, 2, 2);
            this.tlpNounsPanel.Controls.Add(this.txtSecondNoun, 2, 1);
            this.tlpNounsPanel.Controls.Add(this.lblFirstNoun, 1, 0);
            this.tlpNounsPanel.Controls.Add(this.lblSecondNoun, 1, 1);
            this.tlpNounsPanel.Controls.Add(this.lblThirdNoun, 1, 2);
            this.tlpNounsPanel.Controls.Add(this.txtFirstNoun, 2, 0);
            this.tlpNounsPanel.Location = new System.Drawing.Point(0, 85);
            this.tlpNounsPanel.Name = "tlpNounsPanel";
            this.tlpNounsPanel.RowCount = 3;
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNounsPanel.Size = new System.Drawing.Size(984, 218);
            this.tlpNounsPanel.TabIndex = 6;
            // 
            // txtThrdNoun
            // 
            this.txtThrdNoun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThrdNoun.FieldText = "";
            this.txtThrdNoun.Location = new System.Drawing.Point(495, 147);
            this.txtThrdNoun.Name = "txtThrdNoun";
            this.txtThrdNoun.Size = new System.Drawing.Size(240, 68);
            this.txtThrdNoun.TabIndex = 5;
            // 
            // txtSecondNoun
            // 
            this.txtSecondNoun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSecondNoun.FieldText = "";
            this.txtSecondNoun.Location = new System.Drawing.Point(495, 75);
            this.txtSecondNoun.Name = "txtSecondNoun";
            this.txtSecondNoun.Size = new System.Drawing.Size(240, 66);
            this.txtSecondNoun.TabIndex = 4;
            // 
            // lblFirstNoun
            // 
            this.lblFirstNoun.AutoSize = true;
            this.lblFirstNoun.Location = new System.Drawing.Point(249, 0);
            this.lblFirstNoun.Name = "lblFirstNoun";
            this.lblFirstNoun.Size = new System.Drawing.Size(56, 13);
            this.lblFirstNoun.TabIndex = 0;
            this.lblFirstNoun.Text = "First noun:";
            // 
            // lblSecondNoun
            // 
            this.lblSecondNoun.AutoSize = true;
            this.lblSecondNoun.Location = new System.Drawing.Point(249, 72);
            this.lblSecondNoun.Name = "lblSecondNoun";
            this.lblSecondNoun.Size = new System.Drawing.Size(74, 13);
            this.lblSecondNoun.TabIndex = 1;
            this.lblSecondNoun.Text = "Second noun:";
            // 
            // lblThirdNoun
            // 
            this.lblThirdNoun.AutoSize = true;
            this.lblThirdNoun.Location = new System.Drawing.Point(249, 144);
            this.lblThirdNoun.Name = "lblThirdNoun";
            this.lblThirdNoun.Size = new System.Drawing.Size(61, 13);
            this.lblThirdNoun.TabIndex = 2;
            this.lblThirdNoun.Text = "Third noun:";
            // 
            // txtFirstNoun
            // 
            this.txtFirstNoun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstNoun.FieldText = "";
            this.txtFirstNoun.Location = new System.Drawing.Point(495, 3);
            this.txtFirstNoun.Name = "txtFirstNoun";
            this.txtFirstNoun.Size = new System.Drawing.Size(240, 66);
            this.txtFirstNoun.TabIndex = 3;
            // 
            // NounQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tlpNounsPanel);
            this.Name = "NounQuestionForm";
            this.Text = "NounQuestionForm";
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