﻿using ApplicationName.Library.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationName.Library.Impl.Configuration
{
    public static class LibraryExtension
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services)
        {
            services.AddTransient<IFooService, FooService>();
            return services;
        }
    }
}
