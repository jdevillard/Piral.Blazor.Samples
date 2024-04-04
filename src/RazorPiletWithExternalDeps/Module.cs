using ExternalDeps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPiletWithExternalDeps
{
    public class Module : IMfModule
    {
        public Module(IConfiguration configuration)
        {
            // Inject here what you want, e.g., the global `IConfiguration`.
        }

        public void Configure(IServiceCollection services)
        {
            services.AddExternalDeps();
            // Configure your services in this function
        }

        public Task Setup(IMfAppService app)
        {
            app.MapComponent<ComponentDeps>("mfa-pilet-externaldeps-component");
            app.MapComponent<ComponentPilet2>("mfa-pilet-externaldeps-component");
            // Register components and more
            return Task.CompletedTask;
        }

        public Task Teardown(IMfAppService app)
        {
            // Unregister things that need to be cleaned up
            return Task.CompletedTask;
        }
    }
}
