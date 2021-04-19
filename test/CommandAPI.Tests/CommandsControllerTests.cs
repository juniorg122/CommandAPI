using CommandAPI.Data;
using Moq;
using Xunit;
using CommandAPI.Models ; 
using CommandAPI.Controllers ;
using System.Collections.Generic;
using CommandAPI.Profiles;
using AutoMapper ; 

namespace CommandAPI.Tests
{
    public class CommandsControllerTests
    {
        [Fact]
        public void GetCommandItems_ReturnZeroItems_WhenDBIsEmpty()
        {
            var mockRepo = new Mock<ICommandAPIRepo>();
            mockRepo.Setup(repo=> repo.GetAllCommands()).Returns(GetCommands(0));

            var realProfile = new CommandsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(realProfile) );
            IMapper mapper = new Mapper(configuration);
            var controller = new CommandsController(mockRepo.Object, mapper);
            {/*repository , AutoMapper*/};
        //Given
        
        //When
        
        //Then
        }

        private List<Command> GetCommands(int num)
        {
            var commands = new List<Command>();
            if(num>0)
            {
                commands.Add(new Command
                {
                    Id = 0,
                    HowTO = "How To Generate a Migration",
                    CommandLine = "dotnet ef migratons add <Nmae of Migration>",
                    Platform = ".Net Core EF"
                });
                
            }
            return commands ; 
        }
    }
}