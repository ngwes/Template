using Cocona;
using System.Linq;
using TemplateConsole.Shared.Commands;

namespace TemplateConsole.Presentation.Installer
{
    public static class CoconaCommandsInstallerExtension
    {
        public static void InstallCommandsFromAssembly(this CoconaApp app)
        {
            var installers = typeof(Program).Assembly.ExportedTypes
              .Where(x => typeof(ICLICommand).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
              .ToList();
            app.AddCommands(installers);
        }
    }
}
