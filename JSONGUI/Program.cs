using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONTool;

namespace JSONGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            JSON jsonTool = new JSON();

            Console.WriteLine("Please enter in your JSON below to minify");
            string json = Console.ReadLine();
            Console.WriteLine(jsonTool.minify(json));
            Console.ReadLine();
        }
    }
}
