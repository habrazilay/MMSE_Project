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
    public partial class AnalogClockQuestionForm : QuestionForm
    {

        #region Methods

        public AnalogClockQuestionForm()
        {
            base.QuestionTitle = "על המסך מוצג שעון אנלוגי.\r\nעליך לכתוב את השעה המוצגת על המסך (במתכונת של 12 שעות).";
            base.PartNumber = "8";

            InitializeComponent();

            base.ChangeButtonTextToFinish();
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            return returnValue;

        }

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 7;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;
            
            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - Location questions
            FinishQuiz();
        }

        #endregion
    }
}
