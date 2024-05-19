using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Z5r
    {
        class DrugiZadatak
        {
            public List<string> palindromes(List<string> strings)
            {
                List<string> res = new List<string>();
                if (strings == null) return res;
                foreach (string str in strings)
                {
                    
                    if (IsPalindrom(str))
                    {
                        res.Add(str);
                    }
                }
                return res;
            }
            private bool IsPalindrom(string str) 
            {
                string trimmedString = str.Replace(" ", "").ToLower();
                string reversedString = new string(trimmedString.Reverse().ToArray());

                return trimmedString.Equals(reversedString);
            }
        }
    }
}
