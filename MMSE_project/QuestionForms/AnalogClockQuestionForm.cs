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
    public partial class AnalogClockQuestionForm : QuestionForm
    {
        #region Data Member

        List<Image> allClockImages = new List<Image>();
        private List<Image> randomClockImages = new List<Image>();
        private List<string> randomImagesNames = new List<string>();

        private const int FIRST_HOUR = 1;
        private const int LAST_HOUR = 12;
        private const int FIRST_MIN = 10;
        private const int LAST_MIN = 55;


        #endregion


        #region Methods

        public AnalogClockQuestionForm()
        {
            InitAllClockImages();
            RandomClockImages();

            base.QuestionTitle = "על המסך מוצג שעון אנלוגי.\r\nעליך לכתוב את השעה המוצגת על המסך (במתכונת של 12 שעות).";
            base.PartNumber = "8";

            InitializeComponent();

            // Setting a analog clock image in the picture Box

            pbAnalogClockImg.Image = randomClockImages[0];
            FillComboBoxData();
            base.ChangeButtonTextToFinish();
        }
        /// <summary>
        /// Fill hours and minutes combo boxes.
        /// </summary>
        private void FillComboBoxData()
        {

            // Adding all default hours to hoursBox
            for (int hours = FIRST_HOUR; hours <= LAST_HOUR; hours++)
            {
                hoursBox.Items.Add(hours.ToString());
            }
            // Adding all default minutes to minutesBox
            minutesBox.Items.Add("00");
            minutesBox.Items.Add("05");
            for (int minutes = FIRST_MIN; minutes <= LAST_MIN; minutes=minutes+5)
            {
                minutesBox.Items.Add(minutes.ToString());
            }
        }


        // Initialize the analog clocks images 
        private void InitAllClockImages()
        {

            allClockImages.Add(Properties.Resources._155);
            allClockImages[0].Tag = "155";

            allClockImages.Add(Properties.Resources._235);
            allClockImages[1].Tag = "235";

            allClockImages.Add(Properties.Resources._300);
            allClockImages[2].Tag = "300";

            allClockImages.Add(Properties.Resources._445);
            allClockImages[3].Tag = "445";

            allClockImages.Add(Properties.Resources._450);
            allClockImages[4].Tag = "450";

            allClockImages.Add(Properties.Resources._525);
            allClockImages[5].Tag = "525";

            allClockImages.Add(Properties.Resources._605);
            allClockImages[6].Tag = "605";

            allClockImages.Add(Properties.Resources._715);
            allClockImages[7].Tag = "715";

            allClockImages.Add(Properties.Resources._845);
            allClockImages[8].Tag = "845";

            allClockImages.Add(Properties.Resources._955);
            allClockImages[9].Tag = "955";

            allClockImages.Add(Properties.Resources._1010);
            allClockImages[10].Tag = "1010";

            allClockImages.Add(Properties.Resources._1115);
            allClockImages[11].Tag = "1115";

            allClockImages.Add(Properties.Resources._1125);
            allClockImages[12].Tag = "1125";

            allClockImages.Add(Properties.Resources._1200);
            allClockImages[13].Tag = "1200";

            allClockImages.Add(Properties.Resources._1205);
            allClockImages[14].Tag = "1205";

            allClockImages.Add(Properties.Resources._1230);
            allClockImages[15].Tag = "1230";
        }

        // Getting random analog clocks images

        private void RandomClockImages()
        {
            Random random = new Random();
            int index = 0;
            index = random.Next(allClockImages.Count);
            randomClockImages.Add(allClockImages[index]);
            randomImagesNames.Add(allClockImages[index].Tag.ToString());
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            minutesBox.MandatoryMessageVisibility(minutesBox.SelectedItem == null);
            hoursBox.MandatoryMessageVisibility(hoursBox.SelectedItem == null);

            if (minutesBox.SelectedItem == null || hoursBox.SelectedItem == null)
                returnValue = false;


            return returnValue;

        }

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 7;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;
            string selectedHour = hoursBox.SelectedItem.ToString()+minutesBox.SelectedItem.ToString();
            // Check if hour entered is correct according to the analog clock presented
            foreach (string clockHour in randomImagesNames)
                if (selectedHour == clockHour)
            {
                score++;
            }

            
            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - Location questions
            FinishQuiz();
        }

        #endregion
    }
}
