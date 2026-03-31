using System;
using NewNoteAntiTodo.Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        var consoleService = new ConsoleService();
        consoleService.WriteLine("C# 실행파일이 성공적으로 생성되고 실행되었습니다!");
    }
}
