using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDBApp.Command
{
    interface CommandInterface
    {
        public bool CanRun(string input);
        public string Run(string input, ref bool isExit);
        public string GetMenuRow();
    }
}
