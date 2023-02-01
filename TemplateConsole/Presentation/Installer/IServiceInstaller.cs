using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsole.Presentation.Installer
{
    public interface IServiceInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration? configuration);
    }
}
