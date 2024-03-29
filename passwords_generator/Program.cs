
namespace passwords_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NB_PASSWORDS = 10;

            // Demander la longueur du mot de passe (Demander nombre) int longueur_mot_de_passe = ...
            int passwordLength = Tools.RequestPositiveNonNullNumber("Longueur du mot de passe : ");

            Console.WriteLine();
            int choiceAlphabet = Tools.RequestNumberBetween("Vous voulez un mot de passe avec :\n" +
                "1 - Uniquement des caractères en minuscules\n" +
                "2 - Des caractère en minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Caractères, chiffres et caractères spéciaux\n" +
                "Votre choix : ", 1, 4);

            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            string numbers = "0123456789";
            string specialCharacters = "&#@$%!?";
            string alphabet = "";

            Random rand = new Random();

            Console.WriteLine();
            Console.WriteLine("Voici vos mots de passes :\n");

            switch (choiceAlphabet)
            {
                case 1:
                    alphabet = lowercase;
                    break;
                case 2:
                    alphabet = lowercase + uppercase;
                    break;
                case 3:
                    alphabet = lowercase + uppercase + numbers;
                    break;
                case 4:
                    alphabet = lowercase + uppercase + numbers + specialCharacters;
                    break;
                default:
                    Console.WriteLine("ERREUR : Qu'est-ce que vous avez foutu bordel ?!");
                    break;
            }

            int alphabetLength = alphabet.Length;
            string password;

            for (int i = 0; i < NB_PASSWORDS; i++)
            {
                password = "";

                for (int j = 0; j < passwordLength; j++)
                {
                    int index = rand.Next(0, alphabetLength);
                    password += alphabet[index];
                }

                Console.WriteLine($"{password}");
            }

        }
    }
}
