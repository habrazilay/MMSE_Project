using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    static class NounManagment
    {
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
    }
}
