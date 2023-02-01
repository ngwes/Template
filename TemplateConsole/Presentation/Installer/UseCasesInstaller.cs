using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TemplateConsole.Domain.UseCases.SnakeUseCases;

namespace TemplateConsole.Presentation.Installer
{
    public class UseCasesInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration? configuration)
        {
            services.AddScoped<ISnakeService, SnakeService>();
        }
    }
}
