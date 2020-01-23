using System;
using System.Collections.Generic;
using System.Text;

namespace class_coupling
{
    class Text : Presentation_Object
    {
        public int Fontsize { get; set; }
        public string Fontname { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added link to " + url);
        }
    }
}
