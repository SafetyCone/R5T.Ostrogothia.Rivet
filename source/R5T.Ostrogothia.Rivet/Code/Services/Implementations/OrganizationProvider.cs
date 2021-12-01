using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Ostrogothia.Rivet
{
    [ServiceImplementationMarker]
    public class OrganizationProvider : IOrganizationProvider, IServiceImplementation
    {
        public Task<IOrganization> GetOrganization()
        {
            var rivetOrganization = RivetOrganization.Instance as IOrganization;

            return Task.FromResult(rivetOrganization);
        }
    }
}
