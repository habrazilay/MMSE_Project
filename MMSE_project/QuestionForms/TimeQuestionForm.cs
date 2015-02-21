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

        private enum monthsEnum
        {   
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        private enum seasonsEnum
        {
            Autumn = 1,
            Winter,
            Spring,
            Summer

        };

        private const int DEFAULT_MIN_YEAR = 1990;
        private const int DEFAULT_MAX_YEAR = 2050;
        private const int FIRST_DAY        = 1;
        private const int LAST_DAY         = 31;
        private const int FIRST_MONTH      = 1;
        private const int LAST_MONTH       = 12;
        private const int SEASONS_NUM      = 4;

        #endregion


        #region Methods

        public TimeQuestionForm()
        {
            InitializeComponent();

            base.QuestionTitle = "Part 1: Please answer the time questions:";
            base.PartNumber = "Part 1:";
            //   base.timerForQuestion.Start();

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
            for (int month = FIRST_MONTH; month <= LAST_MONTH; month++)
	        {
                monthBox.Items.Add(Enum.GetName(typeof(monthsEnum), (object)month));
            }

            // Adding all days in a month to dayBox
            for (int day = FIRST_DAY; day <= LAST_DAY; day++)
            {
                dayBox.Items.Add(day.ToString());
            }

            // Adding all seasons in a year to seasonBox
            for (int season = 1; season <= SEASONS_NUM; season++)
            {
                seasonBox.Items.Add(Enum.GetName(typeof(seasonsEnum), (object)season));
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
                score++;
            else if ((thisDay.Day + 1 == (int)dayBox.SelectedItem) ||
                     (thisDay.Day - 1 == (int)dayBox.SelectedItem))
                score = score + 0.5;

            // Check if month is correct
            string currMonth = (Enum.GetName(typeof(monthsEnum), thisDay.Month));

            if (currMonth == monthBox.SelectedItem.ToString())
                score++;
            else if (((Enum.GetName(typeof(monthsEnum), (thisDay.Month - 1)) == monthBox.SelectedItem.ToString()) ||
                      (Enum.GetName(typeof(monthsEnum), (thisDay.Month + 1))) == monthBox.SelectedItem.ToString()))
                score = score + 0.5;

            // Check if year s correct
            if (thisDay.Year.ToString() == yearBox.SelectedItem.ToString())
                score++;
            else if ((thisDay.Year + 1 == (int)yearBox.SelectedItem) ||
                     (thisDay.Year - 1 == (int)yearBox.SelectedItem))
                score = score + 0.5;

            // Check if seasion is correct
            // The seasons distributed by - http://www.ynet.co.il/yaan/0,7340,L-18073-PreYaan,00.html
            if (currMonth == "September" ||
                currMonth == "October"   ||
                currMonth == "November")
            {
                currSeason = seasonsEnum.Autumn.ToString();
            }
            else if (currMonth == "December"  ||
                     currMonth == "January"   ||
                     currMonth == "February")
            {
                currSeason = seasonsEnum.Winter.ToString();
            }
            else if (currMonth == "March"  ||
                     currMonth == "April"  ||
                     currMonth == "May")
            {
                currSeason = seasonsEnum.Spring.ToString();
            }
            else if (currMonth == "June"  ||
                     currMonth == "July"  ||
                     currMonth == "August")
            {
                currSeason = seasonsEnum.Summer.ToString();
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
