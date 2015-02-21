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

        private enum citiesEnum
        {   
            TelAviv = 1,
            Jerusalem,
            NewYork,
            BuenosAires,
            Barcelona,
            London,
            Paris,
            BeerSheva,
            Bangkok,
            Marrakech
        };

        private enum countriesEnum
        {
            Israel = 1,
            Spain,
            USA,
            England,
            France,
            Argentina,
            Thailand,
            Morocco
        };

        private const int    DEFAULT_MIN_FLOOR = -3;
        private const int    DEFAULT_MAX_FLOOR = 25;
        private const string CURR_FLOOR        = "7";
        private const string CURR_COUNTRY      = "Israel";
        private const string CURR_CITY         = "Jerusalem";

        #endregion


        #region Methods

        public LocationQuestionForm()
        {
            InitializeComponent();

            base.QuestionTitle    = "Please answer the location questions:";
            base.PartNumber = "Part 2:";

            FillComboBoxData();
        }

        /// <summary>
        /// Fill CITIS, COUNTRIES and FLOORS combo boxes.
        /// </summary>
        private void FillComboBoxData()
        {
            // Adding all cities to cityBox
            for (int city = 1; city <= ((Array)Enum.GetValues(typeof(citiesEnum))).Length; city++)
            {
                cityBox.Items.Add(Enum.GetName(typeof(citiesEnum), (object)city));
            }

            // Adding all countries to countryBox
            for (int country = 1; country <= ((Array)Enum.GetValues(typeof(countriesEnum))).Length; country++)
            {
                countyBox.Items.Add(Enum.GetName(typeof(countriesEnum), (object)country));
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
