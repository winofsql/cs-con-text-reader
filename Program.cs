using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace cs_con_text_reader
{
  class Program
  {
    static void Main(string[] args)
    {

      string? text = "";
      using( var sr = new StreamReader( "utf8n.csv", new UTF8Encoding() ) )
      {
        text = sr.ReadToEnd();
        Console.WriteLine( $"{text}\n" );

        var arr = Regex.Split(text, "\r\n|\n");
        foreach (string line in arr)
        {
            Console.WriteLine( $"{line}\n" );

            var cols = line.Split(',');
            foreach (var item in cols)
            {
              Console.WriteLine( item );
            }

            Console.WriteLine();
        }
      }

    }
  }
}
