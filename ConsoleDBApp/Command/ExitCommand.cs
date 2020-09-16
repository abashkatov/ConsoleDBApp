using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDBApp.Command
{
    class ExitCommand : CommandInterface
    {
        public bool CanRun(string input)
        {
            return input == "exit";
        }

        public string GetMenuRow()
        {
            return "exit - выход";
        }

        public string Run(string input, ref bool isExit)
        {
            isExit = true;
            return "Работа приложения завершена.";
        }
    }
}
