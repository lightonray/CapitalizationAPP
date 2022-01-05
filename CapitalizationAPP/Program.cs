using System;
using System.Globalization;


namespace CapitalizationAPP

{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a word or a sentence: ");

                string input = Console.ReadLine();

                Console.WriteLine(ToTitleCase(input));
            }

            catch(ArgumentException e) // calling the exception from the function
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string ToTitleCase(this string title)
        {

            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Input field must be filled");
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
        }


    }
}
