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
    public partial class NounQuestionForm : QuestionForm
    {
        public NounQuestionForm()
        {
            InitializeComponent();
            base.PartNumber = "5";
            base.QuestionTitle = "אנא הכנס את שלושת שמות העצם שהתבקשת לזכור בחלק מספר 3 (סדר ההכנסה אינו משנה).";
        }

        #region Ovveride Methods

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 4;
        }

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            txtFirstNoun.MandatoryMessageVisibility(txtFirstNoun.FieldText == string.Empty);
            txtSecondNoun.MandatoryMessageVisibility(txtSecondNoun.FieldText == string.Empty);
            txtThrdNoun.MandatoryMessageVisibility(txtThrdNoun.FieldText == string.Empty);

            if (txtFirstNoun.FieldText == string.Empty || txtSecondNoun.FieldText == string.Empty || txtThrdNoun.FieldText == string.Empty)
                returnValue = false;

            return returnValue;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;

            // Getting the shown nouns and check if the user insert them correctly.
            foreach (string noun in NounManagment.GetNounsList())
            {
                if (SpellingCheck.EqualsIgnoringMisspellings(noun, txtFirstNoun.FieldText) ||
                    SpellingCheck.EqualsIgnoringMisspellings(noun, txtSecondNoun.FieldText) ||
                    SpellingCheck.EqualsIgnoringMisspellings(noun, txtThrdNoun.FieldText))
                {
                    score++;
                }
            }

            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - MathQuestionForm
            MathQuestionForm mathQuestionForm = new MathQuestionForm();
            this.Hide();
            mathQuestionForm.Show();
        }
        
        #endregion
    }
}
