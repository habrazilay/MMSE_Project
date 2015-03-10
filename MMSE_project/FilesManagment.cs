using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace MMSE_project
{
    public static class FilesManagment
    {
        #region Data members

        private static StreamReader textStreamReader;
        private static StreamWriter textStreamWriter;
        private static string filePath;

        #endregion


        #region Methods

        static FilesManagment()
        {
            // Getting user results file path 
            string userID = QuizPerUser.currUserID;
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"HistoryFiles\" + userID + ".txt").Replace(@"bin\Debug\", "");

            // Check if file is exist
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                textStreamWriter = new StreamWriter(filePath);
            }
            else
            {
               textStreamWriter = new StreamWriter(filePath, true);
            }
        }


        public static void WriteLineToFile(string line)
        {
            if (textStreamWriter != null)
            {
                textStreamWriter.WriteLine(line);
                textStreamWriter.Close();
            }
        }

        public static List<string> ReadAllLines(string userID)
        {
            List<string> result = new List<string>();

            // get path file by user id
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"HistoryFiles\" + userID + ".txt").Replace(@"bin\Debug\", "");

            // check if the file of user is exist
            if (File.Exists(filePath))
            {
                textStreamReader = File.OpenText(filePath);
                string line = textStreamReader.ReadLine();

                while (line != null)
                {
                    result.Add(line);
                    line = textStreamReader.ReadLine();
                }
            }

            return result;
        }

        #endregion
    }
}
