using ConsoleDBApp.Context;
using ConsoleDBApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDBApp.Command
{
    class GetPersonListCommand : CommandInterface
    {
        private readonly AppDbContext context;

        public GetPersonListCommand(AppDbContext context)
        {
            this.context = context;
        }
        public bool CanRun(string input) => input == "list";

        public string GetMenuRow() => "list - вывод всех записей";

        public string Run(string input, ref bool isExit)
        {
            StringBuilder result = new StringBuilder();
            string separator = "|-----|------------|------------|-----------|";

            WriteLine(separator);
            WriteLine("|   Id| First Name |  Last Name |     Phone |");
            WriteLine(separator);
            foreach (Person person in context.Persons)
            {
                WriteLine($"|{person.Id,5}|{person.FirstName,12}|{person.LastName,12}|{person.Phone,11}|");
            }
            WriteLine(separator);

            return result.ToString();
        }
    }
}
