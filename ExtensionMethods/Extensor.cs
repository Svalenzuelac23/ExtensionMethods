using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensor
    {
        public static int LetterCount (this String str)
        {
            return str.Length;
        }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        
    }
}
