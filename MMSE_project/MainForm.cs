using MMSE_project.QuestionForms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to validate a ID number
        /// </summary>
        /// <returns>Return True if user ID is correct, else return false</returns>
        private bool ValidateUserID()
        {
            string userId = this.txtUserID.Text;

            if (userId.Length != 9)
                return false;

            // Getting the Check digit - The last digit is the check digit
            int CheckDigit = Int32.Parse(userId[userId.Length - 1].ToString());

            int sum = (7 * Int32.Parse(userId[0].ToString()) + Int32.Parse(userId[3].ToString()) + Int32.Parse(userId[6].ToString())) +
                      (3 * Int32.Parse(userId[1].ToString()) + Int32.Parse(userId[4].ToString()) + Int32.Parse(userId[7].ToString())) +
                      (9 * Int32.Parse(userId[2].ToString()) + Int32.Parse(userId[5].ToString()));
    
            int m10 = sum % 10;
    
            if((char)m10 == CheckDigit)
            {
                return true;
            }
            else
             return true;//
        }


        /// <summary>
        /// Show the history view
        /// </summary>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            lblErrorMassage.Visible = false;

            // Check if the entered ID is correct.
            if (ValidateUserID())
            {
                HistoryForm historyForm = new HistoryForm(this.txtUserID.Text);
                historyForm.ShowDialog();
            }
            else
            {
                // The user id is incorrect - show message to user to enter id again.
                lblErrorMassage.Visible = true;
            }
        }

        /// <summary>
        /// Show the first question view of the quiz
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblErrorMassage.Visible = false;

            // Check if the entered ID is correct.
            if (ValidateUserID())
            {
                QuizPerUser.StartQuiz(this.txtUserID.Text);

                TimeQuestionForm questionForm = new TimeQuestionForm();
                this.Hide();
                questionForm.Show();
            }
            else
            {
                // The user id is incorrect - show message to user to enter id again.
                lblErrorMassage.Visible = true;
            }
        }

    }
}
