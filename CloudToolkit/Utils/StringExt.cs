using System;

namespace CloudToolkit.Util
{
    public static class StringExt
    {
        public static string RemoveLast(this string text, string character)
        {
            if (text.Length < 1)
                return text;
            return text.Remove(text.LastIndexOf(character, StringComparison.Ordinal), character.Length);
        }
    }
}
