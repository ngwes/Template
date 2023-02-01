using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsole.Presentation.Installer
{
    public static class ServicesInstallerExtension
    {
        public static IServiceCollection InstallServices(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Program).Assembly.ExportedTypes
               .Where(x => typeof(IServiceInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
               .Select(Activator.CreateInstance)
               .Cast<IServiceInstaller>()
               .ToList();
            installers.ForEach(installer => installer.InstallServices(services, configuration));
            return services;
        }
    }
}
