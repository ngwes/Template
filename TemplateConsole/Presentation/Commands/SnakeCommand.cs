using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateConsole.Domain.UseCases.SnakeUseCases;
using TemplateConsole.Shared.Commands;

namespace TemplateConsole.Presentation.Commands
{
    public class SnakeCommand : ICLICommand
    {
        private readonly ISnakeService _snakeService;
        public SnakeCommand(ISnakeService snakeService)
        {
            _snakeService = snakeService;
        }

        public void CreateSnake()
        {
            _snakeService.CreateSnake();
        }

        public void CreateLazySnake()
        {
            _snakeService.CreateLazySnake();
        }

    }
}
