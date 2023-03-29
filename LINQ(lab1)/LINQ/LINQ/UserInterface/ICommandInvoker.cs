namespace LINQ.UserInterface;

public interface ICommandInvoker
{
    void InvokeCommand(ExecutingCommandType commandType);
}