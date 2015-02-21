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
    class FilesManagment
    {
        #region Data members

        StreamReader textStreamReader;

        #endregion


        #region Methods

        private string GetFile(string fileName)
        {
            Assembly assembly;
            
            try
            {
                assembly = Assembly.GetExecutingAssembly();
                textStreamReader = new StreamReader(assembly.GetManifestResourceStream("MMSE_project.Resources.ResultsFile"));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            return "";
        }

        private void WriteLineToFile()
        {

        }

        private void ReadLineFromFile()
        {

        }

        #endregion
    }
}
