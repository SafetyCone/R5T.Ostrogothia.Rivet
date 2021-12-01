using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Ostrogothia.Rivet
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationProvider"/> implementation of <see cref="IOrganizationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationProvider> AddOrganizationProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IOrganizationProvider>(services => services.AddOrganizationProvider());
            return serviceAction;
        }
    }
}
