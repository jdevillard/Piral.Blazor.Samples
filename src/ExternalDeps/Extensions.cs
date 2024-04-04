using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalDeps
{
    public static class Extensions
    {
        public static IServiceCollection AddExternalDeps(this IServiceCollection services)
        {
            services.AddSingleton<ITestInjection, TestInjection>();
            return services;
        }
    }
}
