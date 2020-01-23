using System;
using System.Collections.Generic;
using System.Text;

namespace class_coupling
{
    class Presentation_Object
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Coppied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Duplicated");
        }
    }
}
