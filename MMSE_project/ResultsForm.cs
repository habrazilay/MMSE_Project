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
    public partial class ResultsForm : Form
    {
        #region Methods & Events

        public ResultsForm()
        {
            InitializeComponent();

            lblScore.Text = "Your final score is: " + QuizPerUser.TotalQuizScore + ".";
            lblTime.Text = "You finish the quiz in " + QuizPerUser.TotalQuizTime.Hours + " hours, " +
                                                       QuizPerUser.TotalQuizTime.Minutes + " minutes and " +
                                                       QuizPerUser.TotalQuizTime.Seconds + " seconds";
        }

        /// <summary>
        /// Back to manu page - show mainform
        /// </summary>
        private void btnBackToManu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        #endregion
    }
}
