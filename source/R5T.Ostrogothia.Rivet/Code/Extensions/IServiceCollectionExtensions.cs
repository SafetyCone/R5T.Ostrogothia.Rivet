using Microsoft.Extensions.DependencyInjection;
using R5T.T0063;
using System;



namespace R5T.Ostrogothia.Rivet
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationProvider, OrganizationProvider>();

            return services;
        }
    }
}
