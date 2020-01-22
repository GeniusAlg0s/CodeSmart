using System;
using System.Collections.Generic;
using System.Text;

namespace textprac
{
    public class summary
    {
        public static string summerizestr(string text, int maxsize = 20)
        {
            //   const int maxsize = 20;
            if (text.Length < maxsize)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalchar = 0;
                //sentence.Substring(0, maxsize);
                var summary = new List<string>();

                foreach (var word in words)
                {
                    summary.Add(word);
                    totalchar += word.Length + 1;
                    if (totalchar > maxsize)
                        break;
                }
                //var sum = String.Join(" ", summary) + "...";
                return String.Join(" ", summary) + "...";
            }
          //  public static string strbuilder()
        }
    }
}
