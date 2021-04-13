using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List <Command>
            {
                new Command{Id = 0, HowTO="How to generate a migration",CommandLine="dotnet ef migrations add <Name of Migration>",
                Platform=".Net Core EF"},
                new Command{Id=1,HowTO="Run Migrations",CommandLine="dotnet ef database update",Platform=".Net Core EF"},
                new Command{Id=2,HowTO="List Active Migrations",CommandLine="dotnet ef migrations list",
                Platform=".Net Core EF"}
            };
            return commands ; 
        }

        public Command GetCommandbyId(int id)
        {
            return new Command{Id = 0, HowTO="How to generate a migration",CommandLine="dotnet ef migrations add <Name of Migration>",
                Platform=".Net Core EF"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}