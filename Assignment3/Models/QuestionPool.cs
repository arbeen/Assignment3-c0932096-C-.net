namespace Assignment3.Models;
public static class QuestionPool
{
    public static List<Question> GetQuestions()
    {
        return new List<Question>
            {
                new Question { Id = 1, Text = "What does C# primarily run on?", Options = new List<string> { "JVM", ".NET Framework", "Python Interpreter", "Ruby on Rails" }, CorrectAnswerIndex = 1 },
                new Question { Id = 2, Text = "Which of the following is a value type in C#?", Options = new List<string> { "string", "class", "int", "object" }, CorrectAnswerIndex = 2 },
                new Question { Id = 3, Text = "Which operator is used for logical AND in C#?", Options = new List<string> { "&&", "||", "&", "|" }, CorrectAnswerIndex = 0 },
                new Question { Id = 4, Text = "Which method is used to write output to the console in C#?", Options = new List<string> { "print()", "Console.Write()", "Console.Log()", "echo()" }, CorrectAnswerIndex = 1 },
                new Question { Id = 5, Text = "What is C# primarily used for?", Options = new List<string> { "Web Development", "Game Development", "Desktop Applications", "All of the above" }, CorrectAnswerIndex = 3 },
                new Question { Id = 6, Text = "Which company developed C#?", Options = new List<string> { "Google", "Apple", "Microsoft", "IBM" }, CorrectAnswerIndex = 2 },
                new Question { Id = 7, Text = "What does CLR stand for in .NET?", Options = new List<string> { "Common Language Runtime", "Code Logic Repository", "C# Language Runtime", "Common Library Resource" }, CorrectAnswerIndex = 0 },
                new Question { Id = 8, Text = "Which keyword is used to define a class in C#?", Options = new List<string> { "class", "Class", "define", "struct" }, CorrectAnswerIndex = 0 },
                new Question { Id = 9, Text = "Which of the following is NOT a valid C# data type?", Options = new List<string> { "int", "string", "char", "array" }, CorrectAnswerIndex = 3 },
                new Question { Id = 10, Text = "Which access modifier makes a member visible only within its class?", Options = new List<string> { "public", "private", "protected", "internal" }, CorrectAnswerIndex = 1 },
                new Question { Id = 11, Text = "What is the extension of a C# source file?", Options = new List<string> { ".cs", ".csharp", ".cpp", ".c" }, CorrectAnswerIndex = 0 },
                new Question { Id = 12, Text = "Which keyword is used for exception handling in C#?", Options = new List<string> { "try-catch", "throw", "catch", "handle" }, CorrectAnswerIndex = 0 },
                new Question { Id = 13, Text = "Which of the following is NOT a loop in C#?", Options = new List<string> { "for", "foreach", "loop", "while" }, CorrectAnswerIndex = 2 },
                new Question { Id = 14, Text = "What is the default value of an uninitialized `int` variable in C#?", Options = new List<string> { "0", "null", "undefined", "1" }, CorrectAnswerIndex = 0 },
                new Question { Id = 15, Text = "What does ASP.NET Core MVC stand for?", Options = new List<string> { "Active Server Pages Model View Controller", "Application Server Pages Model View Controller", "ASP.NET Model View Controller", "None of the above" }, CorrectAnswerIndex = 2 },
                new Question { Id = 16, Text = "Which keyword is used to inherit a class in C#?", Options = new List<string> { "inherits", "extend", "base", ":" }, CorrectAnswerIndex = 3 },
                new Question { Id = 17, Text = "What is the base class for all C# classes?", Options = new List<string> { "System", "Object", "Base", "Class" }, CorrectAnswerIndex = 1 },
                new Question { Id = 18, Text = "Which method is used to read input from the console in C#?", Options = new List<string> { "Console.Read()", "Console.ReadKey()", "Console.ReadLine()", "Console.Input()" }, CorrectAnswerIndex = 2 },
                new Question { Id = 19, Text = "Which of the following is a reference type in C#?", Options = new List<string> { "int", "double", "string", "char" }, CorrectAnswerIndex = 2 },
                new Question { Id = 20, Text = "Which of these statements is TRUE about C#?", Options = new List<string> { "C# is case-insensitive", "C# supports multiple inheritance", "C# is an interpreted language", "C# supports automatic garbage collection" }, CorrectAnswerIndex = 3 },
                new Question { Id = 21, Text = "Which keyword is used to define an interface in C#?", Options = new List<string> { "interface", "Interface", "implements", "contract" }, CorrectAnswerIndex = 0 },
                new Question { Id = 22, Text = "What is the main entry point for a C# application?", Options = new List<string> { "Start()", "Main()", "Execute()", "Run()" }, CorrectAnswerIndex = 1 },
                new Question { Id = 23, Text = "Which framework is used to develop web applications in C#?", Options = new List<string> { ".NET Core", "Spring Boot", "Django", "Laravel" }, CorrectAnswerIndex = 0 },
            };

        }
}
