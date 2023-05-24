using State;
using State.UserInterface;

class Program
{
    static void Main(string[] args)
    {
        UserData userData = new UserData();
        userData.GrantInitializer();
        AdminConsole adminConsole = new AdminConsole(userData.Contexts);
        adminConsole.Prosses();
    }
}