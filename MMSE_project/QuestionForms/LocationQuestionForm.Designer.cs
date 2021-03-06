﻿namespace MMSE_project.QuestionForms
{
    partial class LocationQuestionForm
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
            this.cityBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.countyBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.floorBox = new MMSE_project.QuestionForms.MandatoryComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.tlpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
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
            // tlpQuestion
            // 
            this.tlpQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestion.ColumnCount = 2;
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQuestion.Controls.Add(this.cityBox, 1, 0);
            this.tlpQuestion.Controls.Add(this.countyBox, 1, 1);
            this.tlpQuestion.Controls.Add(this.floorBox, 1, 2);
            this.tlpQuestion.Controls.Add(this.lblCity, 0, 0);
            this.tlpQuestion.Controls.Add(this.lblCountry, 0, 1);
            this.tlpQuestion.Controls.Add(this.lblFloor, 0, 2);
            this.tlpQuestion.Location = new System.Drawing.Point(0, 80);
            this.tlpQuestion.Name = "tlpQuestion";
            this.tlpQuestion.RowCount = 3;
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpQuestion.Size = new System.Drawing.Size(584, 302);
            this.tlpQuestion.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.DropDownHeight = 150;
            this.cityBox.Location = new System.Drawing.Point(53, 3);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(236, 56);
            this.cityBox.TabIndex = 20;
            // 
            // countyBox
            // 
            this.countyBox.DropDownHeight = 106;
            this.countyBox.Location = new System.Drawing.Point(53, 103);
            this.countyBox.Name = "countyBox";
            this.countyBox.Size = new System.Drawing.Size(236, 52);
            this.countyBox.TabIndex = 19;
            // 
            // floorBox
            // 
            this.floorBox.DropDownHeight = 150;
            this.floorBox.Location = new System.Drawing.Point(53, 203);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(236, 52);
            this.floorBox.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCity.Location = new System.Drawing.Point(390, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(191, 20);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "באיזו עיר אתה נמצא כרגע?";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCountry.Location = new System.Drawing.Point(375, 100);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(206, 20);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "באיזו מדינה אתה נמצא כרגע?";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFloor.Location = new System.Drawing.Point(336, 200);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(245, 20);
            this.lblFloor.TabIndex = 13;
            this.lblFloor.Text = "באיזו קומה בבינין אתה נמצא כרגע?";
            // 
            // LocationQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tlpQuestion);
            this.Name = "LocationQuestionForm";
            this.Text = this.Text;
            this.Controls.SetChildIndex(this.titleSplitter, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.buttonSplitter, 0);
            this.Controls.SetChildIndex(this.lblPartNum, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.tlpQuestion, 0);
            this.tlpQuestion.ResumeLayout(false);
            this.tlpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpQuestion;
        private MandatoryComboBox cityBox;
        private MandatoryComboBox countyBox;
        private MandatoryComboBox floorBox;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblFloor;

    }
}