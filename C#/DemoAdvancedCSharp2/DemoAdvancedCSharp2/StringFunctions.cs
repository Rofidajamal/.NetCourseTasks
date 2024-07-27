using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdvancedCSharp2
{
    internal class StringFunctions
    {
        public static int GetCountUpperChars (string word)
        {
            int count = 0;
            if (word is not null)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i])){
                        count++;
                    }
                }

            }
            return count;
        }


        public static int GetCountLowerChars(string word)
        {
            int count = 0;
            if (word is not null)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
