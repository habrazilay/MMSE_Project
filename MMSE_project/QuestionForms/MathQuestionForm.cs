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
    public partial class MathQuestionForm : QuestionForm
    {
        #region Data members
        
        private const int SEVEN_NUM = 7;

        private double score                 = 0;
        private int    first_number          = 100;
        private bool   isFinishedToCalculate = false;

        #endregion


        #region  Methods & Events

        public MathQuestionForm()
        {
            base.QuestionTitle = "אאנא ענה על השאלה החישובית הבאה:";
            base.PartNumber = "6";

            InitializeComponent();

            lblQuestion.Text = first_number + " - " + SEVEN_NUM + " = ";
            base.btnNext.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                score = CheckAnswers();

                // Setting the next math question
                first_number = Int32.Parse(txtResult.FieldText);

                if (first_number - SEVEN_NUM > 0)
                {
                    lblQuestion.Text = first_number + " - " + SEVEN_NUM + " = ";
                    txtResult.FieldText = string.Empty;
                }
                else
                {
                    base.btnNext.Enabled      = true;
                    this.btnCalculate.Visible = false;
                    isFinishedToCalculate     = true;
                }                
            }
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 5;
        }

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            txtResult.MandatoryMessageVisibility(txtResult.FieldText == string.Empty);

            if (txtResult.FieldText == string.Empty)
                returnValue = false; 

            return (returnValue || isFinishedToCalculate);

        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            if (!isFinishedToCalculate)
            {
                if (Int32.Parse(txtResult.FieldText) == (first_number - SEVEN_NUM))
                {
                    score++;
                }
                else if ((Int32.Parse(txtResult.FieldText) + 1 == (first_number - SEVEN_NUM)) ||
                         (Int32.Parse(txtResult.FieldText) - 1 == (first_number - SEVEN_NUM)))
                {
                    score = score + 0.5;
                }
            }

            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - TimesConvertQuestionForm
            TimesConvertQuestionForm timesConvertQuestionForm = new TimesConvertQuestionForm();
            this.Hide();
            timesConvertQuestionForm.Show();
        }

        #endregion
    }
}
