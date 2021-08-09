using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Assessments
{
    public class WordPattern
    {
        public bool Execute(string pattern, string s)
        {
            string[] words = s.Split(' ');

            Dictionary<char, string> dict = new Dictionary<char, string>();

            if(words.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                string expectedValue = "";
                bool isExisted = dict.TryGetValue(pattern[i], out expectedValue);

                if(isExisted)
                {
                    if (expectedValue != words[i]) return false;
                }
                else
                {
                    string valueExisted = dict.Values.FirstOrDefault(x => x == words[i]);
                    if (valueExisted != null) return false;

                    dict.Add(pattern[i], words[i]);
                }
            }

            return true;
        }
    }
}
