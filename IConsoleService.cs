namespace NewNoteAntiTodo.Core
{
    public interface IConsoleService
    {
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
        void Clear();
    }
}
