using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MMSE_project.QuestionForms
{
    public partial class NounImagesQuestionForm : QuestionForm
    {
        #region Data Member
        #endregion
        #region Methods

        public NounImagesQuestionForm()
        {
            InitializeComponent();

            base.PartNumber = "Part 4:";
            base.QuestionTitle = "There are 3 Images of nouns. Please fill the noun name in the fields below.";
 
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 3;
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



            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - 
            NounQuestionForm nounQuestionForm = new NounQuestionForm();
            this.Hide();
            nounQuestionForm.Show(); 
        }

        #endregion
    }
}
