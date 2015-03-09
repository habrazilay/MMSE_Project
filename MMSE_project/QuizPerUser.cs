using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    class QuizPerUser
    {
        #region Data members

        public  static string   currUserID;
        private static List<QuestionResult> questionsResultsList;
        private static double   totalQuizScore;
        private static TimeSpan totalQuizTime;
        public  static DateTime quizStartTime;

        #endregion


        #region Getting/Setting properties

        public static double TotalQuizScore
        {
            get
            {
                totalQuizScore = 0;
                foreach (QuestionResult questionResult in questionsResultsList)
                {
                    totalQuizScore = totalQuizScore + questionResult.Score;
                }

                return totalQuizScore;
            }
            set
            {
                totalQuizScore = value;
            }
        }

        public static List<QuestionResult> QuestionsResultsList
        {
            get
            {
                if (questionsResultsList == null)
                    questionsResultsList = new List<QuestionResult>();

                return questionsResultsList;
            }
        }

        public static TimeSpan TotalQuizTime
        {
            get
            {
                foreach (QuestionResult questionResult in questionsResultsList)
                {
                    totalQuizTime = totalQuizTime + questionResult.TimeToQuestion;
                }

                return totalQuizTime;
            }
            set
            {
                totalQuizTime = value;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// The methods called when user starting a new quiz, and init all the quiz parameter.
        /// </summary>
        public static void StartQuiz(string userID)
        {
             currUserID = userID;
             questionsResultsList = new List<QuestionResult>();
             totalQuizScore = 0;
             totalQuizTime = TimeSpan.Zero;
             quizStartTime = DateTime.Now;
        }

        /// <summary>
        /// The methods called when user finish his quiz.
        /// It saving the quiz results at file.
        /// </summary>
        public static void FinishQuiz()
        {
            string quesetionsData = string.Empty;

            foreach (QuestionResult qr in questionsResultsList)
	        {
		        quesetionsData = quesetionsData + qr.QuestionNumber + "|" + qr.Score + "|" + qr.TimeToQuestion;
	        }

            FilesManagment.WriteLineToFile(quizStartTime.Date + "|" +
                                           quizStartTime.TimeOfDay + "|" +
                                           currUserID + "|" +
                                           totalQuizScore + "|" +
                                           totalQuizTime + "|" +
                                           quesetionsData);

        }

        #endregion
    }
}
