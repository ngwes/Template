using Microsoft.Extensions.Logging;
using TemplateConsole.Shared.Commands;

namespace TemplateConsole.Presentation.Commands
{
    public class HelloWorldCommand : ICLICommand
    {
        private readonly ILogger<HelloWorldCommand> _logger;
        public HelloWorldCommand(ILogger<HelloWorldCommand> logger)
        {
            _logger = logger;
        }
        public void Hello()
        {
            _logger.LogInformation("Hello There");
            Console.ReadLine();
        }
    }
}
