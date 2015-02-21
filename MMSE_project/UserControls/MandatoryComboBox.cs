using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project.QuestionForms
{
    public partial class MandatoryComboBox : UserControl
    {
        #region Getting/Setting properties

        public object SelectedItem
        { 
            get { return cmbList.SelectedItem; } 
        }

        public ComboBox.ObjectCollection Items
        { 
            get { return cmbList.Items; } 
        }

        public int DropDownHeight
        { 
            get { return cmbList.DropDownHeight; }
            set { this.cmbList.DropDownHeight = value; }
        }


        #endregion


        #region Methods

        public MandatoryComboBox()
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
