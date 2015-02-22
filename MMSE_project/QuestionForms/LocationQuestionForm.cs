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
    public partial class LocationQuestionForm : QuestionForm
    {
        #region Data Member

        private const int DEFAULT_MIN_FLOOR = -3;
        private const int DEFAULT_MAX_FLOOR = 25;
        private const string CURR_FLOOR = "7";
        private const string CURR_COUNTRY = "ישראל";
        private const string CURR_CITY = "ירושלים";

        List<string> citiesList = new List<string>(new string[] { "תל אביב", CURR_CITY, "ניו יורק", "בואנוס איירס", "פריז",
                                                                  "ברצלונה", "באר שבע", "מרקש", "בנגקוק", "לונדון" });

        List<string> countiesList = new List<string>(new string[] { CURR_COUNTRY, "צרפת", "ארצות הברית", "אנגליה", "פרו",
                                                                    "ספרד", "תאילנד", "מרוקן", "ארגנטינה", "פורטוגל"});

        #endregion


        #region Methods

        public LocationQuestionForm()
        {
            base.QuestionTitle = "אנא ענה על שאלון התמצאות במקום.";
            base.PartNumber = "2";

            InitializeComponent();

            FillComboBoxData();
        }

        /// <summary>
        /// Fill CITIS, COUNTRIES and FLOORS combo boxes.
        /// </summary>
        private void FillComboBoxData()
        {
            // Adding all cities to cityBox
            for (int city = 0; city < citiesList.Count; city++)
            {
                cityBox.Items.Add(citiesList[city]);
            }

            // Adding all countries to countryBox
            for (int country = 0; country < countiesList.Count; country++)
            {
                countyBox.Items.Add(countiesList[country]);
            }

            // Adding all floors to floorBox
            for (int floor = DEFAULT_MIN_FLOOR; floor <= DEFAULT_MAX_FLOOR; floor++)
            {
                floorBox.Items.Add(floor.ToString());
            }
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 2;
        }

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            cityBox.MandatoryMessageVisibility(cityBox.SelectedItem == null);
            countyBox.MandatoryMessageVisibility(countyBox.SelectedItem == null);
            floorBox.MandatoryMessageVisibility(floorBox.SelectedItem == null);

            if (cityBox.SelectedItem == null || countyBox.SelectedItem == null || floorBox.SelectedItem == null)
                returnValue = false;

            return returnValue;

        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;

            // Check if city is correct
            if (CURR_CITY == cityBox.SelectedItem.ToString())
                score++;

            // Check if country is correct
            if (CURR_COUNTRY == countyBox.SelectedItem.ToString())
                score++;

            // Check if floor s correct
            if (CURR_FLOOR == floorBox.SelectedItem.ToString())
                score++;
            else if ((Int32.Parse(CURR_FLOOR) + 1).ToString() == floorBox.SelectedItem.ToString() ||
                     (Int32.Parse(CURR_FLOOR) - 1).ToString() == floorBox.SelectedItem.ToString())
                score = score + 0.5;

            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - Noun lables form
            NounLabelsForm nounLabelsForm = new NounLabelsForm();
            this.Hide();
            nounLabelsForm.Show();
        }

        #endregion
   
    }
}
