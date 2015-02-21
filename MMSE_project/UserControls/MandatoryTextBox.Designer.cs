namespace MMSE_project.UserControls
{
    partial class MandatoryTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(0, 24);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(225, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "* Mandatory field. Please answer the question.";
            this.lblMessage.Visible = false;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(0, 0);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(222, 20);
            this.txtField.TabIndex = 3;
            // 
            // MandatoryTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.lblMessage);
            this.Name = "MandatoryTextBox";
            this.Size = new System.Drawing.Size(233, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtField;
    }
}
