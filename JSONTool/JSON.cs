namespace JSONTool
{
    public class JSON
    {
        public static string minify(string json)
        {
            //Return the json string.
            return System.Text.RegularExpressions.Regex.Replace(json, "(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+", "$1");
        }
    }
}
