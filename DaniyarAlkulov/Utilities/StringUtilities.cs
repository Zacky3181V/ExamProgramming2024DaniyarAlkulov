namespace Utilities
{
    public static class StringUtilities
    {
        public static int LongWordsCount(string str)
        {
            
            return str.Split(' ').Length;
        }

        public static string SpinalCase(string str)
        {
            var a = str.ToLower().Split(' ');
            return string.Join("-", a);
        }

        //it was easier for me to create this method to solve ToPascalCase task
        public static string ToSentence(string str)
        {
            var a = str[0].ToString().ToUpper();
            var b = str[1..].ToString().ToLower();
            return $"{a}{b}";
        }
        public static string ToPascalCase(string str)
        {
            var a = str.Split(' ');
            for(var i = 0; i < a.Length; i++)
            {
                a[i] = ToSentence(a[i]);
            }
            return string.Join("", a);
        }
    }
}
