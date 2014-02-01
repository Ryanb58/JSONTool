namespace JSONTool
{
    public class JSON
    {
        public string minify(string json)
        {
            //Return the json string. (added simpler reg exp)
            return System.Text.RegularExpressions.Regex.Replace(json, "(\"(?:[^\"|.])*\")|\\s+", "$1");
        }
    }
}
