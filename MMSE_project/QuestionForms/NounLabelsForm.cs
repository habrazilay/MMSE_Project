using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project.QuestionForms
{
    public partial class NounLabelsForm : Form
    {
        #region Data Members

        private const int NUM_OF_NOUNS = 3;
        private const int MAX_SECOUNDS = 10;

        private List<string> nounsList = new List<string>(new string[] { "כסא", "ילדה", "פעמון", "מפתח", "תמונה",
                                                                         "אבוקדו", "כדורסל", "מטבח", "שבת", "תחרות" });

        private int wordNumber    = 0;
        private int secondNumber = MAX_SECOUNDS;

        #endregion
     

        #region Methods
       
        public NounLabelsForm()
        {
            randomNouns();

            InitializeComponent();

            lblExplain.Visible = true;
            lblNoun.Visible = false;

            explainTimer.Enabled = true;
            explainTimer.Start();
        }

        /// <summary>
        /// Getting random nouns
        /// </summary>
        private void randomNouns()
        {
         //   Array values = Enum.GetValues(typeof(NounsEnum));
            Random random = new Random();

            string randomNoun = nounsList[random.Next(nounsList.Count)];  
            bool isAllDifferentNouns = false;

            while (!isAllDifferentNouns)
            {
                randomNoun = nounsList[random.Next(nounsList.Count)];

                if (!NounManagment.GetNounsList().Contains(randomNoun))
                    NounManagment.AddNounToList(randomNoun);

                if (NounManagment.GetNounsList().Count == NUM_OF_NOUNS)
                    isAllDifferentNouns = true;
               
            } 
        }

        /// <summary>
        /// Setting noun on label from nounsList
        /// </summary>
        private void SetNounLabel(int index)
        {
            lblNoun.Text = NounManagment.GetNounsList()[index];
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>
        /// Setting second on label
        /// </summary>
        private void SetSecondLabel()
        {
            lblTimeLeft.Text = secondNumber.ToString();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        #endregion


        #region Events


        /// <summary>
        /// Event that append after the first 10 secounds - 10 seconds for explaination.
        /// </summary>
        private void explainTimer_Tick(object sender, EventArgs e)
        {
            lblExplain.Visible = false;
            lblNoun.Visible = true;
            explainTimer.Stop();

            lblTitle.Text = "חלק מספר 3:\r\nיופיעו על המסך 3 שמות עצם, אחד אחרי השני, כל אחד למשך 10 שניות בלבד.\r\nעליך לשנן ש" +
                            "מות עצם אלו ולזכור אותם כי\r\nבהמשך השאלון תדרש לכתוב את שלושת שמות עצם אלו.";

            SetNounLabel(wordNumber);
            wordsTimer.Enabled = true;
            wordsTimer.Interval = 1000;
            wordsTimer.Start();
        }

        /// <summary>
        /// Event that append evety 10 secounds - Set the next noun on label/Change Form after 3 nouns
        /// </summary>
        private void wordsTimer_Tick(object sender, EventArgs e)
        {
            if (secondNumber == 0)
            {
                wordNumber++;
                secondNumber = MAX_SECOUNDS;

                if (wordNumber != 3)
                {
                    SetNounLabel(wordNumber);
                }
                else
                {
                    wordsTimer.Stop();
                    NounImagesQuestionForm nounImagesQuestionForm = new NounImagesQuestionForm();
                    this.Hide();
                    nounImagesQuestionForm.Show();
                }
            }
            else
            { 
                secondNumber--;                
            }

            SetSecondLabel();
        }

        #endregion

    }
}
