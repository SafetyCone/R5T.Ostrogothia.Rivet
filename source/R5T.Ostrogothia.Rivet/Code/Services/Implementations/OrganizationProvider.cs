using System;
using System.Threading.Tasks;


namespace R5T.Ostrogothia.Rivet
{
    public class OrganizationProvider : IOrganizationProvider
    {
        public Task<IOrganization> GetOrganization()
        {
            var rivetOrganization = RivetOrganization.Instance as IOrganization;

            return Task.FromResult(rivetOrganization);
        }
    }
}
