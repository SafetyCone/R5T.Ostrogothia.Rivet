using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Ostrogothia.Rivet
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationProvider, OrganizationProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationProvider> AddOrganizationProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOrganizationProvider>(() => services.AddOrganizationProvider());
            return serviceAction;
        }
    }
}
