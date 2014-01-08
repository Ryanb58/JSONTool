using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSONTool
{
    public class JSON
    {
        public string minify(string json)
        {
            //This will hold the result of the string.
            string jsonResult = "";

            //int to tell which " or ' you are at.
            int quotes = 0;

            //Loops through each character in the json sent.
            foreach (char c in json)
            {
                
                if (c.ToString() == "\"" || c.ToString() == "\'")
                {
                    quotes += 1;
                    if (quotes == 2)
                    {
                        quotes = 0;
                    }
                }

                //If any white or null spaces are found, remove them. Except in quotes.
                if (!String.IsNullOrWhiteSpace(c.ToString()))
                {
                    jsonResult += c.ToString();
                }
                else if (quotes == 1)
                {
                    jsonResult += c.ToString();
                }
            }
            //Return the json string.
            return jsonResult;
        }
    }
}
