using StructuralDesignPatterns.User;

namespace StructuralDesignPatterns;

internal static class Program
{
    public static void Main()
    {
        UserData userData = new UserData();
        userData.CardInitializer();
        UserInterface userInterface = new UserInterface(userData.Data);
        userInterface.Prosses();
    }
}