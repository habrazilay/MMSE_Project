using MMSE_project.QuestionForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project
{
    public partial class QuestionForm : Form, IQuestion
    {
        #region Data Members

        private const string FINISH_TEXT = "סיים!";
        private const string NEXT_TEXT   = "הבא";

        private QuestionResult qrQuestionResult;
        private Stopwatch      stopwatch;

        #endregion


        #region Getting & Setting Properties

        public QuestionResult QuestionResult
        {
            get { return this.qrQuestionResult; }
            set { this.qrQuestionResult = value; }
        }

        public string QuestionTitle
        {
            set { this.lblTitle.Text = value; }
        }

        public string PartNumber
        {
            set 
            {
                this.lblPartNum.Text = "חלק מספר " + value + ":"; 
            }
        }

        public void StartStopwatch()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        #endregion


        #region Methods & Events

        public QuestionForm()
        {
            InitializeComponent();
            qrQuestionResult = new QuestionResult();
            StartStopwatch();
        }

        /// <summary>
        /// Change next button to finish button
        /// </summary>
        public void ChangeButtonTextToFinish()
        {
            this.btnNext.Text = FINISH_TEXT;
        }

        /// <summary>
        /// Save and show user results
        /// </summary>
        public void FinishQuiz()
        {
            // Save user's quis details to file
            QuizPerUser.FinishQuiz();

            // Show the result screen
            ResultsForm resultForm = new ResultsForm();
            this.Hide();
            resultForm.Show();
        }

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public virtual bool CheckValidation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public virtual double CheckAnswers()
        {
            throw new NotImplementedException();
        }

        public virtual void NextButtonClick()
        {
            throw new NotImplementedException();
        }

        public virtual int GetQuestionNumber()
        {
            throw new NotImplementedException();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check question answers and score
            if (CheckValidation())
            {
                stopwatch.Stop();

                QuestionResult.QuestionNumber = GetQuestionNumber();
                QuestionResult.Score = CheckAnswers();
                QuestionResult.TimeToQuestion = stopwatch.Elapsed;

                QuizPerUser.QuestionsResultsList.Add(QuestionResult);

                NextButtonClick();
            }
        }

        #endregion
    }
}
