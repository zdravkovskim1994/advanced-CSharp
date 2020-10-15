using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class TextReader
    {
        public static string TextReaderFile(string filePath)
        {
            if (File.Exists(filePath))
            {
              string content = File.ReadAllText(filePath);
                return content;

            }
            return null;
        }

       
        public static string ReverseText(string content)
        {
            string[] contentArray = content.Split(' ');
            Array.Reverse(contentArray);
            string result = String.Join(" ", contentArray);
            return result;
        }

        public static string ReverseCharacter(string content)
        {
            var n = content.ToArray().Reverse().ToArray();
            string result = String.Join("", n);
            return result;
        }

        public static void WriteTextOnNewFile(string path, string text)
        {
            
                File.AppendAllText(path, text + Environment.NewLine);
            
        }
    }
}
