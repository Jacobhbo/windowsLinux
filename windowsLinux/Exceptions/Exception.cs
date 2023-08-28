using System;

namespace windowsLinux.Exceptions
{
    internal class Exception
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast din fødselsdato (dd-MM-yyyy): ");
            string fødselsdatoString = Console.ReadLine();

            try
            {
                DateTime fødselsdatoDateTime = Convert.ToDateTime(fødselsdatoString);

                Console.WriteLine("Fødselsdato: " + fødselsdatoDateTime.ToShortDateString());
            }
            catch
            {
                Console.WriteLine("Format af din input er forkert!");
            }

            if (DateTime.TryParseExact(fødselsdatoString, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fødselsdatoExact))
            {
                Console.WriteLine("Fødselsdato: " + fødselsdatoExact.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Format af din input er forkert (TryParseExact)!");
            }
        }
    }
}
