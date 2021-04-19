using Xunit;
using CommandAPI.Models ; 
using System ; 
namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand ; 
        public CommandTests()
        {
            testCommand = new Command 
            {
                HowTO = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }
        [Fact]
        public void CanChangeHowTO()
        {
          

            //Act
            testCommand.HowTO = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTO);

        }
    [Fact]
        public void CanChangePlatform()
        {
            testCommand.Platform = "Milfs";
            Assert.Equal("Milfs", testCommand.Platform);
        }
        [Fact]
        public void CanChangeCommandLine()
        {
            testCommand.CommandLine = "Grab them by the balls";
            Assert.Equal("Grab them by the balls",testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null ; 
        }
    }
}