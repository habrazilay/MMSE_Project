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
    public partial class TimesConvertQuestionForm : QuestionForm
    {

        #region Data Member

        List<Image> allHourImages = new List<Image>();
        private List<Image> randomHourImages = new List<Image>();
        private List<string> randomImagesNames = new List<string>();

        #endregion
        #region Methods

        public TimesConvertQuestionForm()
        {

            InitAllHourImages();
            RandomHourImages();

            base.QuestionTitle = "על המסך מוצגת שעה הכתובה בעברית\r\nעליך לכתוב את השעה המוצגת כקלט את השעה והדקות במספרים - במתוכנת של 24 שעות.";
            base.PartNumber = "7";

            InitializeComponent();

            // Setting an hour image in the picture Box

            pbConvertHour.Image = randomHourImages[0];
        }

        private void InitAllHourImages()
        {

            allHourImages.Add(Properties.Resources.h0030);
            allHourImages[0].Tag = "0030";

            allHourImages.Add(Properties.Resources.h0135);
            allHourImages[1].Tag = "0135";

            allHourImages.Add(Properties.Resources.h0515);
            allHourImages[2].Tag = "0515";

            allHourImages.Add(Properties.Resources.h0715);
            allHourImages[3].Tag = "0715";

            allHourImages.Add(Properties.Resources.h1030);
            allHourImages[4].Tag = "1030";

            allHourImages.Add(Properties.Resources.h1320);
            allHourImages[5].Tag = "1320";

            allHourImages.Add(Properties.Resources.h1510);
            allHourImages[6].Tag = "1510";

            allHourImages.Add(Properties.Resources.h1510);
            allHourImages[7].Tag = "1510";

            allHourImages.Add(Properties.Resources.h2050);
            allHourImages[8].Tag = "2050";

            allHourImages.Add(Properties.Resources.h2115);
            allHourImages[9].Tag = "2115";
        }

        // Getting random hour images

        private void RandomHourImages()
        {
            Random random = new Random();
            int index = 0;
            index = random.Next(allHourImages.Count);
            randomHourImages.Add(allHourImages[index]);
            randomImagesNames.Add(allHourImages[index].Tag.ToString());
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            txtConvertHour.MandatoryMessageVisibility(txtConvertHour.FieldText == string.Empty);
            if (txtConvertHour.FieldText == string.Empty)
                returnValue = false;


            return returnValue;

        }

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 6;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;

            foreach (string hourImage in randomImagesNames)
            {
                if (SpellingCheck.EqualsIgnoringMisspellings(hourImage, txtConvertHour.FieldText))
                {
                    score++;
                }
            }
            
            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - Location questions
            AnalogClockQuestionForm analogClockForm = new AnalogClockQuestionForm();
            this.Hide();
            analogClockForm.Show(); 
        }

        #endregion
    }
}
