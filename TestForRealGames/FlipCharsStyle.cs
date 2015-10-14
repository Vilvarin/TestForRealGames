using System;

namespace TestForRealGames
{
    /// <summary>
    /// переставляет символы в обратном порядке
    /// </summary>
    class FlipCharsStyle : IStyle
    {
        public string HandleText(string text)
        {
            string output = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                output += text[i];
            }

            return output;
        }
    }
}
