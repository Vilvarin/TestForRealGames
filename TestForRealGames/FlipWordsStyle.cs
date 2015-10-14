using System;
using System.Collections.Generic;

namespace TestForRealGames
{
    /// <summary>
    /// переставляет слова в обратном порядке
    /// </summary>
    class FlipWordsStyle : IStyle
    {
        public string HandleText(string text)
        {
            string output = "";
            string word = "";
            List<string> words = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]) || i == text.Length)
                {
                    words.Add(word);
                    word = "";
                }
                else
                {
                    word += text[i];
                }
            }

            for (int i = words.Count-1; i >= 0; i--)
            {
                output += words[i] + " ";
            }

            return output;
        }
    }
}
