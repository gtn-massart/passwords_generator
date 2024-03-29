
namespace passwords_generator
{
    internal class Tools
    {
        public static int RequestPositiveNonNullNumber(string question)
        {
            return RequestNumberBetween(question, 1, int.MaxValue, "ERREUR : Le nombre doit être positif et non null.");
        }

        public static int RequestNumberBetween(string question, int min, int max, string customErrorMessage = null)
        {
            int number = RequestNumber(question);

            if (number >= min && number <= max)
            {
                return number;
            }

            if (customErrorMessage == null)
            {
                Console.WriteLine($"ERREUR : Le nombre doit être compris entre {min} et {max}.");
            }
            else
            {
                Console.WriteLine(customErrorMessage);
            }
            Console.WriteLine();

            return RequestNumberBetween(question, min, max, customErrorMessage); // Fonction récursive
        }

        public static int RequestNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                try
                {
                    int responseInt = int.Parse(Console.ReadLine());
                    return responseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Veuillez entrer un nombre valide.");
                    Console.WriteLine();
                }
            }
        }
    }
}
