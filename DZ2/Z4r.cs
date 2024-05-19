using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Z4r
    {
        class DrugiZadatak
        {
            public static List<char> uniqueChars(string text)
            {
                List<char> chars = new List<char>();
                for (int i = 0; i < text.Length; i++)
                {
                    
                   
                        if (CharactherOcurrence(text, text[i]==1))
                        {
                            chars.Add(text[i]);
                        }
                    
                    
                }
                return chars;
            }
            public int CharactherOcurrence(string text, char charachter) 
            {
                int count = 0;
                for(int i=0; i< text.Length; i++) 
                {
                    if (text[i] == charachter) { count++; }
                }
                return count;
            }
        }
    }
}
