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

            base.ChangeButtonTextToFinish();
        }

        // Initialize the analog clocks images 

        private void InitAllClockImages()
        {
            allClockImages.Add(Properties.Resources._0155);
            allClockImages[0].Tag = "0155";

            allClockImages.Add(Properties.Resources._0235);
            allClockImages[1].Tag = "0235";

            allClockImages.Add(Properties.Resources._0300);
            allClockImages[2].Tag = "0300";

            allClockImages.Add(Properties.Resources._0445);
            allClockImages[3].Tag = "0445";

            allClockImages.Add(Properties.Resources._0450);
            allClockImages[4].Tag = "0450";

            allClockImages.Add(Properties.Resources._0525);
            allClockImages[5].Tag = "0525";

            allClockImages.Add(Properties.Resources._0605);
            allClockImages[6].Tag = "0605";

            allClockImages.Add(Properties.Resources._0715);
            allClockImages[7].Tag = "0715";

            allClockImages.Add(Properties.Resources._0845);
            allClockImages[8].Tag = "0845";

            allClockImages.Add(Properties.Resources._0955);
            allClockImages[9].Tag = "0955";

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

        /// Getting random analog clocks images

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
