﻿namespace MMSE_project.QuestionForms
{
    partial class TimeQuestionForm
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
            this.tlpQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.seasonBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.dayBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.monthBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.yearBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.tlpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(250, 406);
            this.btnNext.Size = new System.Drawing.Size(95, 27);
            // 
            // titleSplitter
            // 
            this.titleSplitter.Size = new System.Drawing.Size(584, 80);
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.Size = new System.Drawing.Size(584, 80);
            // 
            // tlpQuestion
            // 
            this.tlpQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestion.ColumnCount = 2;
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQuestion.Controls.Add(this.seasonBox, 1, 3);
            this.tlpQuestion.Controls.Add(this.dayBox, 1, 0);
            this.tlpQuestion.Controls.Add(this.monthBox, 1, 1);
            this.tlpQuestion.Controls.Add(this.yearBox, 1, 2);
            this.tlpQuestion.Controls.Add(this.seasonLabel, 0, 3);
            this.tlpQuestion.Controls.Add(this.dayLabel, 0, 0);
            this.tlpQuestion.Controls.Add(this.monthLabel, 0, 1);
            this.tlpQuestion.Controls.Add(this.yearLabel, 0, 2);
            this.tlpQuestion.Location = new System.Drawing.Point(0, 80);
            this.tlpQuestion.Name = "tlpQuestion";
            this.tlpQuestion.RowCount = 4;
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpQuestion.Size = new System.Drawing.Size(584, 302);
            this.tlpQuestion.TabIndex = 6;
            // 
            // seasonBox
            // 
            this.seasonBox.DropDownHeight = 106;
            this.seasonBox.Location = new System.Drawing.Point(53, 228);
            this.seasonBox.Name = "seasonBox";
            this.seasonBox.Size = new System.Drawing.Size(236, 68);
            this.seasonBox.TabIndex = 21;
            // 
            // dayBox
            // 
            this.dayBox.DropDownHeight = 150;
            this.dayBox.Location = new System.Drawing.Point(53, 3);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(236, 56);
            this.dayBox.TabIndex = 20;
            // 
            // monthBox
            // 
            this.monthBox.DropDownHeight = 106;
            this.monthBox.Location = new System.Drawing.Point(53, 78);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(236, 52);
            this.monthBox.TabIndex = 19;
            // 
            // yearBox
            // 
            this.yearBox.DropDownHeight = 150;
            this.yearBox.Location = new System.Drawing.Point(53, 153);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(236, 52);
            this.yearBox.TabIndex = 18;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seasonLabel.Location = new System.Drawing.Point(295, 225);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(173, 77);
            this.seasonLabel.TabIndex = 17;
            this.seasonLabel.Text = "מהי עונת השנה הנוכחית?";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dayLabel.Location = new System.Drawing.Point(295, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(192, 75);
            this.dayLabel.TabIndex = 16;
            this.dayLabel.Text = "מה הוא היום הנוכחי בחודש?";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.monthLabel.Location = new System.Drawing.Point(295, 75);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(137, 75);
            this.monthLabel.TabIndex = 15;
            this.monthLabel.Text = "מהו החודש הנוכחי?";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.yearLabel.Location = new System.Drawing.Point(295, 150);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(138, 75);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "מהי השנה הנוכחית?";
            // 
            // TimeQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tlpQuestion);
            this.Name = "TimeQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.tlpQuestion, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.tlpQuestion.ResumeLayout(false);
            this.tlpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpQuestion;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private MandatoryComboBox seasonBox;
        private MandatoryComboBox dayBox;
        private MandatoryComboBox monthBox;
        private MandatoryComboBox yearBox;


    }
}