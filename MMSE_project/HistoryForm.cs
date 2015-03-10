using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project
{
    public partial class HistoryForm : Form
    {
        public string userId;

        public HistoryForm(string userID)
        {
            this.userId = userID;
            InitializeComponent();        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            List<string> userHistoryLines = new List<string>();
            
            userHistoryLines = FilesManagment.ReadAllLines(userId);

            foreach (string line in userHistoryLines)
            {
                 string[] column = line.Split('|');
                 grdHistory.Rows.Add(column[0], column[2], column[3]);
            }
        }
    }
}
