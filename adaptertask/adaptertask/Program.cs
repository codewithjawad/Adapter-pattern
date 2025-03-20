using System.Xml;
using System;

namespace adaptertask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            XMLCODE x = new XMLCODE();
            ConvertxmltoJSON c = new ConvertxmltoJSON(x);
            Console.WriteLine(c.Convert());
            

        }
    }
}
