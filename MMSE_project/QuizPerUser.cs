using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    class QuizPerUser
    {
        public  static string   userID;
        private static List<QuestionResult> questionsResultsList;
        private static double   totalQuizScore;
        private static TimeSpan totalQuizTime;
        public  static DateTime quizStartTime;

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
    }
}
