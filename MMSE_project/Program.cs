using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSE_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #region Noun List

        private static List<string> nounList = new List<string>();

        public static List<string> GetNounsList()
        {
            return nounList;
        }

        public static void SetNounsList(List<string> list)
        {
            nounList = list;
        }

        public static void AddNounToList(string noun)
        {
            nounList.Add(noun);
        }

        #endregion
    }
}
