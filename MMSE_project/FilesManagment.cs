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

        private StreamReader textStreamReader;
        private StreamWriter textStreamWriter;

        #endregion


        #region Methods

        private void GetFileReaderAndWriter(string fileName)
        {
            Assembly assembly;
            
            try
            {
                assembly = Assembly.GetExecutingAssembly();
                textStreamReader = new StreamReader(assembly.GetManifestResourceStream("MMSE_project.Resources.ResultsFile"));
                textStreamWriter = new StreamWriter(assembly.GetManifestResourceStream("MMSE_project.Resources.ResultsFile"));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
        }

        private void WriteLineToFile(string line)
        {
            if (textStreamWriter != null)
            {
                textStreamWriter.WriteLine(line);
            }
        }

        private string ReadLineFromFile()
        {
            string result = string.Empty;

            if (textStreamReader != null)
                result = textStreamReader.ReadLine();

            return result;
        }

        private string ReadAllLines()
        {
            string result = string.Empty;

            if (textStreamReader != null)
                result = textStreamReader.ReadToEnd();

            return result;
        }

        #endregion
    }
}
