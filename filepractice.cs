using System;
using System.IO;

namespace filepract
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   var path = @"c:\somefile.jpg";
               File.Copy(@"c:\temp\myfilr.jpg", "d:\temp\myfile.jpg", true);
               File.Delete(path);

               if (File.Exists(path))
               {
                   //
               }
              var content = File.ReadAllText(path);

               var fileinfo = new FileInfo(path);
               fileinfo.CopyTo("...");
               fileinfo.Delete();
               if (fileinfo.Exists)
               {

               }
               Directory.CreateDirectory(@"c:\temp\folder1");
              var files = Directory.GetFiles(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
               foreach (var file in files)
                   Console.WriteLine(file); */

            var path = @"C:\Users\plwg1\Documents\MS Purdue\IT540 Mang IT Syst\Unit 6\Unit 6\draft.docx";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("extension: " + Path.GetExtension(path));
            Console.WriteLine("Filename: " + Path.GetFileName(path));
            Console.WriteLine("no extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Filename: " + Path.GetDirectoryName(path));


        }
    }
}
