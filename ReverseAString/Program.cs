using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text; 
            Console.Write("Wpisz tekst: ");

            text = Console.ReadLine();

            Console.WriteLine("Wpisany tekst zawiera " + text.Length + " znaków");
            Console.WriteLine("Odwrócony tekst: " + Reverse(text));
            Console.WriteLine("Wciśnij Enter, aby zakończyć program");

            Console.ReadLine();
            
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();

            string reverse = String.Empty;

            for(int i=cArray.Length -1; i > -1; i--)
            {
                reverse = reverse + cArray[i];
            }
            
            return reverse;
        }


    }
}
