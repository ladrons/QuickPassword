using QuickPassword.Enums;
using QuickPassword.Services.Interfaces;
using System.Text;

namespace QuickPassword.Services
{
    public class PasswordGeneratorService : IPasswordGeneratorService
    {
        private static readonly Random Random = new Random();
        private static readonly StringBuilder stringBuilder = new StringBuilder();

        private const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "0123456789";
        private const string symbols = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        // Generates a password based on the length and character types
        public string GeneratePassword(int length, List<CharacterTypes> characterTypes)
        {
            var validChars = new StringBuilder();

            if (characterTypes.Count == 0)
                return "Please select at least one character type.";

            if (characterTypes.Contains(CharacterTypes.Lowercase))
                validChars.Append(lowercaseLetters);
            if (characterTypes.Contains(CharacterTypes.Uppercase))
                validChars.Append(uppercaseLetters);
            if (characterTypes.Contains(CharacterTypes.Numbers))
                validChars.Append(numbers);
            if (characterTypes.Contains(CharacterTypes.Symbols))
                validChars.Append(symbols);

            stringBuilder.Clear();

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(validChars[Random.Next(0, validChars.Length)]);
            }
            return stringBuilder.ToString();
        }
    }
}