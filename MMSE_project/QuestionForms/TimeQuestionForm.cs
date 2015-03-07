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
    public partial class TimeQuestionForm : QuestionForm
    {
        #region Data Members

        private List<string> monthList = new List<string>(new string[] {"ינואר", "פברואר", "מרץ",
                                                                        "אפריל", "מאי", "יוני",
                                                                        "יולי", "אוגוסט", "ספטמבר",
                                                                        "אוקטובר", "נובמבר", "דצמבר"});

        private List<string> seasonList = new List<string>(new string[] { "סתיו", "חורף", "אביב", "קיץ" });

        private const int DEFAULT_MIN_YEAR = 1990;
        private const int DEFAULT_MAX_YEAR = 2050;
        private const int FIRST_DAY        = 1;
        private const int LAST_DAY         = 31;
        private const int LAST_MONTH       = 12;
        private const int SEASONS_NUM      = 4;

        #endregion


        #region Methods

        public TimeQuestionForm()
        {
            base.QuestionTitle = "אנא ענה על שאלון התמצאות בזמן.";
            base.PartNumber = "1";

            InitializeComponent();

            FillComboBoxData();
            
        }

        /// <summary>
        /// Fill YEARS, MONTHS, SEASONS and DAYS combo boxes.
        /// </summary>
        private void FillComboBoxData()
        {
            // Adding all default years to yearBox
            for (int year = DEFAULT_MIN_YEAR; year <= DEFAULT_MAX_YEAR; year++)
            {
                yearBox.Items.Add(year.ToString());
            }

            // Adding all months in a year to monthBox
            for (int month = 0; month < LAST_MONTH; month++)
	        {
                monthBox.Items.Add(monthList[month]);
            }

            // Adding all days in a month to dayBox
            for (int day = FIRST_DAY; day <= LAST_DAY; day++)
            {
                dayBox.Items.Add(day.ToString());
            }

            // Adding all seasons in a year to seasonBox
            for (int season = 0; season < SEASONS_NUM; season++)
            {
                seasonBox.Items.Add(seasonList[season]);
            }
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            dayBox.MandatoryMessageVisibility(dayBox.SelectedItem == null);
            monthBox.MandatoryMessageVisibility(monthBox.SelectedItem == null);
            yearBox.MandatoryMessageVisibility(yearBox.SelectedItem == null);
            seasonBox.MandatoryMessageVisibility(seasonBox.SelectedItem == null);

            if (dayBox.SelectedItem == null  || monthBox.SelectedItem == null ||
                yearBox.SelectedItem == null || seasonBox.SelectedItem == null)
                returnValue = false;

            return returnValue;

        }

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 1;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;
            string currSeason = string.Empty;
            DateTime thisDay = DateTime.Today;

            // Check if day is correct
            if (thisDay.Day.ToString() == dayBox.SelectedItem.ToString())
            {
                score++;
            }

            else if ((thisDay.Day + 1 == Convert.ToInt32(dayBox.SelectedItem)
                    || (thisDay.Day - 1 == Convert.ToInt32(dayBox.SelectedItem))))
            {
                score = score + 0.5;
            }               

            // Check if month is correct
            int currMonthIndex = thisDay.Month + 1;
            string currMonth = monthList[currMonthIndex];

            if (currMonth == monthBox.SelectedItem.ToString())
                score++;
            else if (((monthList[currMonthIndex - 1] == monthBox.SelectedItem.ToString()) ||
                       monthList[currMonthIndex + 1] == monthBox.SelectedItem.ToString()))
            {
                score = score + 0.5;
            }

            // Check if year s correct
            if (thisDay.Year.ToString() == yearBox.SelectedItem.ToString())
                score++;
            else if ((thisDay.Year + 1 == Convert.ToInt32(yearBox.SelectedItem)) ||
                     (thisDay.Year - 1 == Convert.ToInt32(yearBox.SelectedItem)))
            {
                score = score + 0.5;
            }

            // Check if seasion is correct
            // The seasons distributed by - http://www.ynet.co.il/yaan/0,7340,L-18073-PreYaan,00.html
            if (thisDay.Month == 9 ||
                thisDay.Month == 10 ||
                thisDay.Month == 11)
            {
                // The current season is "Autumn"
                currSeason = seasonList[0];
            }
            else if (thisDay.Month == 12 ||
                     thisDay.Month == 1 ||
                     thisDay.Month == 2)
            {
                // The current season is "Winter"
                currSeason = seasonList[1];
            }
            else if (thisDay.Month == 3 ||
                     thisDay.Month == 4 ||
                     thisDay.Month == 5)
            {
                // The current season is "Spring"
                currSeason = seasonList[2];
            }
            else if (thisDay.Month == 6 ||
                     thisDay.Month == 7 ||
                     thisDay.Month == 8)
            {
                // The current season is "Summer"
                currSeason = seasonList[3];
            }

            if (currSeason == seasonBox.SelectedItem.ToString())
                score++;

            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - Location questions
            LocationQuestionForm locationForm = new LocationQuestionForm();
            this.Hide();
            locationForm.Show();
        }

        #endregion
    }
}
