using ConsoleDBApp.Context;
using ConsoleDBApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleDBApp.Command
{
    class AddPersonCommand : CommandInterface
    {
        private readonly AppDbContext context;

        public AddPersonCommand(AppDbContext context)
        {
            this.context = context;
        }

        public bool CanRun(string input) => input == "add";

        public string GetMenuRow() => "add - добавить новую запись";

        public string Run(string input, ref bool isExit)
        {
            Person person = new Person();
            Write("Введите имя: ");
            person.FirstName = ReadLine();
            Write("Введите фамилию: ");
            person.LastName= ReadLine();
            Write("Введите телефон: ");
            person.Phone = ReadLine();

            context.Persons.Add(person);
            context.SaveChanges();

            return "Новая запись была добавлена";
        }
    }
}
