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

        private enum NounsEnum
        {
            Table = 1,
            Girl = 2,
            Bell = 3,
            Key = 4,
            Picture = 5,
            Avocado = 6,
            Basketball = 7,
            Kitchen = 8,
            Wednesday = 9,
            Competition = 10
        };

        private int wordNumber    = 0;
        private int secoundNumber = MAX_SECOUNDS;

        #endregion
     

        #region Methods
       
        public NounLabelsForm()
        {
            randomNouns();

            InitializeComponent();

            lblExplain.Visible = true;
            lblNoun.Visible = false;

            lblExplain.Text = @"It's going to appear on the screen three objects.\r\When it finished, Please repeat them.\r\ " +
                               "Remember what they are because you will name them again in a few minutes. ";
 
            explainTimer.Enabled = true;
            explainTimer.Start();
        }

        /// <summary>
        /// Getting random nouns
        /// </summary>
        private void randomNouns()
        {
            Array values = Enum.GetValues(typeof(NounsEnum));
            Random random = new Random();

            NounsEnum randomNoun = (NounsEnum)values.GetValue(random.Next(values.Length));
            NounManagment.AddNounToList(randomNoun.ToString());
             
            bool isAllDifferentNouns = false;

            while (!isAllDifferentNouns)
            {
                randomNoun = (NounsEnum)values.GetValue(random.Next(values.Length));

                if (!NounManagment.GetNounsList().Contains(randomNoun.ToString()))
                    NounManagment.AddNounToList(randomNoun.ToString());

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
            lblTimeLeft.Text = secoundNumber.ToString();
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

            lblTitle.Text = @"Part 3: It's going to appear on the screen three objects.\r\ When it finished, Please repeat them.\r\ " +
                            "Remember what they are because you will name them again in a few minutes. ";

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
            if (secoundNumber == 0)
            {
                wordNumber++;
                secoundNumber = MAX_SECOUNDS;

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
                secoundNumber--;                
            }

            SetSecondLabel();
        }

        #endregion

    }
}
