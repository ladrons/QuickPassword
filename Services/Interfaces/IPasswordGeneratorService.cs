using QuickPassword.Enums;

namespace QuickPassword.Services.Interfaces
{
    public interface IPasswordGeneratorService
    {
        string GeneratePassword(int length, List<CharacterTypes> characterTypes);
    }
}