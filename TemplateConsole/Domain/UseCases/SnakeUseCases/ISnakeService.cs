using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsole.Domain.UseCases.SnakeUseCases
{
    public interface ISnakeService
    {
        void CreateSnake();
        void CreateLazySnake();
    }
}
