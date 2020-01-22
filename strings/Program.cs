using System;
using System.Text;
using System.Collections.Generic;


namespace textprac
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Pat Williams ";

            Console.WriteLine("Trim: '{0}'", fullname.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);

            Console.WriteLine("firstname : " + firstName + "\nlastname : " + lastName);

            var names = fullname.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            Console.WriteLine(fullname.Replace("Pat", "Patrick"));
            Console.WriteLine();
           Console.WriteLine(fullname.Replace("i", "I"));
            Console.WriteLine();
           Console.WriteLine(fullname.Replace(" ", "xxx"));

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("invalid");
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("invalid");
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var str = "25";
           var age =  Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

            var sentence = " we are going for very very long text that we are going to try and summarize";
            var strsum = summary.summerizestr(sentence);
            var newsum = summary.summerizestr(sentence, 25);
            Console.WriteLine(strsum);
            Console.WriteLine(newsum);

            var builder = new StringBuilder("hello everyone");
            builder.Append('-', 10)
            .AppendLine()
           .AppendLine("header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("first char" + builder[0]);


        }
      /*  static string summerizestr(string text, int maxsize = 20)
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
        } */
    }
}
