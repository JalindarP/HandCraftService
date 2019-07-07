using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using Repository.Contracts;
using Repository.Implementation;

namespace Repository
{
    public static class Bootstrapper
    {
        public static void Initialize(IServiceCollection services, BootstrapperOptions options)
        {
            services.AddTransient(x => new DbContext(options.ConnectionString, options.DatabaseName));

            services.AddTransient<DbContext>(x => new DbContext(
                options.ConnectionString,
                options.DatabaseName));

            services.AddTransient<IJewelryRepositorycs, JewelryRepository>();
        }
    }
}
