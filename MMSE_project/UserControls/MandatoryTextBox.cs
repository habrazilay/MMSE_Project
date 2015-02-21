using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project.UserControls
{
    public partial class MandatoryTextBox : UserControl
    {
        #region Getting/Setting properties

        public string FieldText
        {
            get{ return this.txtField.Text; }
            set { this.txtField.Text = value; }
        }

        #endregion

        #region Methods

        public MandatoryTextBox()
        {
            InitializeComponent();
        }

        public void MandatoryMessageVisibility(bool isVisible)
        {
            lblMessage.Visible = isVisible;
        }

        #endregion
    }
}
