using System;


namespace R5T.Ostrogothia.Rivet
{
    public static class RivetOrganization
    {
        public const string Name = "Rivet";


        #region Static

        public static Organization Instance { get; } = new Organization(RivetOrganization.Name);

        #endregion
    }
}
