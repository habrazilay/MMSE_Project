using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSE_project
{
    public static class SpellingCheck
    {
        private static Dictionary<char, List<char>> similarLetters;
        
        static SpellingCheck()
        {
            similarLetters = new Dictionary<char, List<char>>();
        
            similarLetters['א'] = new List<char>() {'ע', 'ה'};
            similarLetters['ב'] = new List<char>() { 'ו'};
            similarLetters['ה'] = new List<char>() { 'ע', 'א' };
            similarLetters['ו'] = new List<char>() { 'ב' };
            similarLetters['ח'] = new List<char>() { 'כ' , 'ך' };
            similarLetters['ט'] = new List<char>() { 'ת' };
            similarLetters['כ'] = new List<char>() { 'ח' , 'ך' , 'ק'};
            similarLetters['ך'] = new List<char>() { 'ח', 'כ', 'ק' };
            similarLetters['מ'] = new List<char>() { 'ם' };
            similarLetters['ם'] = new List<char>() { 'מ' };
            similarLetters['נ'] = new List<char>() { 'ן' };
            similarLetters['ן'] = new List<char>() { 'נ' };
            similarLetters['ס'] = new List<char>() { 'ש' };
            similarLetters['ע'] = new List<char>() { 'ה', 'א' };
            similarLetters['פ'] = new List<char>() { 'ף' };
            similarLetters['ף'] = new List<char>() { 'פ' };
            similarLetters['צ'] = new List<char>() { 'ץ' };
            similarLetters['ץ'] = new List<char>() { 'צ' };
            similarLetters['ק'] = new List<char>() { 'כ' , 'ך'};
            similarLetters['ש'] = new List<char>() { 'ס' };
            similarLetters['ת'] = new List<char>() { 'ט' };
        }

        private static bool IsMisspellings(char original, char second)
        {
            return similarLetters.ContainsKey(original) && similarLetters[original].Contains(second);
        }

        public static bool EqualsIgnoringMisspellings(string original, string second)
        {
            original = original.Replace("יי", "י");
            second = second.Replace("יי", "י");

            if (original.Length == second.Length)
            {
                for (int i = 0; i < original.Length; i++)
                {
                    if (original[i] != second[i] && !IsMisspellings(original[i], second[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
