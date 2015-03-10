using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MMSE_project.QuestionForms
{
    public partial class NounImagesQuestionForm : QuestionForm
    {
        #region Data Member

        private const int NUM_OF_NOUNS_IMAGES = 3;

        List<Image> allNounImages              = new List<Image>();
        private List<Image> randomImages       = new List<Image>();
        private List<string> randomImagesNames = new List<string>();

        #endregion


        #region Methods

        public NounImagesQuestionForm()
        {
            InitAllNounImages();
            randomNounsImages();

            base.PartNumber = "4";
            base.QuestionTitle = @"אנא מלא את שמות העצם בשדה הטקסט שליד כל תמונה.";
        
            InitializeComponent();
    
            // Setting images in pictureBoxes
            pbFirstNounImage.Image = randomImages[0];
            pbSecondNounImage.Image = randomImages[1];
            pbThirdNounImage.Image = randomImages[2];
        }

        /// <summary>
        /// Initialize the 10 pictures 
        /// </summary>
        private void InitAllNounImages()
        {
            allNounImages.Add(Properties.Resources.Ball);
            allNounImages[0].Tag = "כדור";

            allNounImages.Add(Properties.Resources.Banana);
            allNounImages[1].Tag = "בננה";

            allNounImages.Add(Properties.Resources.Book);
            allNounImages[2].Tag = "ספר";

            allNounImages.Add(Properties.Resources.Car);
            allNounImages[3].Tag = "מכונית";

            allNounImages.Add(Properties.Resources.Cat);
            allNounImages[4].Tag = "חתול";

            allNounImages.Add(Properties.Resources.Hammer);
            allNounImages[5].Tag = "פטיש";

            allNounImages.Add(Properties.Resources.Hat);
            allNounImages[6].Tag = "כובע";

            allNounImages.Add(Properties.Resources.Horse);
            allNounImages[7].Tag = "סוס";

            allNounImages.Add(Properties.Resources.House);
            allNounImages[8].Tag = "בית";

            allNounImages.Add(Properties.Resources.Sun);
            allNounImages[9].Tag = "שמש";
        }

        /// <summary>
        /// Getting random nouns images
        /// </summary>
        private void randomNounsImages()
        {
            Random random = new Random();

            int index = -1;
            bool isAllDifferentNouns = false;

            while (!isAllDifferentNouns)
            {
                index = random.Next(allNounImages.Count);

                if (!randomImages.Contains(allNounImages[index]))
                {
                    randomImages.Add(allNounImages[index]);
                    randomImagesNames.Add(allNounImages[index].Tag.ToString());
                }

                if (randomImages.Count == NUM_OF_NOUNS_IMAGES)
                    isAllDifferentNouns = true;
            }
        }

        #endregion


        #region Ovveride Methods

        /// <summary>
        /// Return the number of the question
        /// </summary>
        public override int GetQuestionNumber()
        {
            return 3;
        }

        /// <summary>
        /// Check if user enter an answers, and not forget an empty fileds
        /// </summary>
        public override bool CheckValidation()
        {
            bool returnValue = true;

            txtFirstNoun.MandatoryMessageVisibility(txtFirstNoun.FieldText == string.Empty);
            txtSecondNoun.MandatoryMessageVisibility(txtSecondNoun.FieldText == string.Empty);
            txtThrdNoun.MandatoryMessageVisibility(txtThrdNoun.FieldText == string.Empty);

            if (txtFirstNoun.FieldText == string.Empty || txtSecondNoun.FieldText == string.Empty || txtThrdNoun.FieldText == string.Empty)
                returnValue = false;
            
            return returnValue;
        }

        /// <summary>
        /// Check if the user answers is correct, and return the score for this question
        /// </summary>
        public override double CheckAnswers()
        {
            double score = 0;

            // Check if the user insert images objects correctly.
            foreach (string nounImage in randomImagesNames)
            {
                if (SpellingCheck.EqualsIgnoringMisspellings(nounImage, txtFirstNoun.FieldText) ||
                    SpellingCheck.EqualsIgnoringMisspellings(nounImage, txtSecondNoun.FieldText) ||
                    SpellingCheck.EqualsIgnoringMisspellings(nounImage, txtThrdNoun.FieldText))
                {
                    score++;
                }
            }

            return score;
        }

        public override void NextButtonClick()
        {
            // Go to the next screen - 
            NounQuestionForm nounQuestionForm = new NounQuestionForm();
            this.Hide();
            nounQuestionForm.Show(); 
        }

        #endregion
    }
}
