using ConsoleDBApp.Command;
using ConsoleDBApp.Context;
using System;
using static System.Console;
using System.Collections.Generic;

namespace ConsoleDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            List<CommandInterface> commands = new List<CommandInterface>();
            commands.Add(new ExitCommand());
            commands.Add(new AddPersonCommand(context));
            commands.Add(new GetPersonListCommand(context));
            bool isExit = false;
            string input;
            string commandResult;
            do {
                WriteLine("===========================================");
                foreach (CommandInterface command in commands) {
                    WriteLine(command.GetMenuRow());
                }
                WriteLine();
                Write("Введите команду: ");
                input = ReadLine();
                foreach (CommandInterface command in commands)
                {
                    if (command.CanRun(input)) {
                        commandResult = command.Run(input, ref isExit);
                        WriteLine(commandResult);
                        break;
                    }
                }
            } while (!isExit);
            ReadKey();
        }
    }
}
