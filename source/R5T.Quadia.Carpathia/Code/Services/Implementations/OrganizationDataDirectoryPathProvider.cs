using System;
using System.Threading.Tasks;

using R5T.Carpathia;
using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Quadia.Carpathia
{
    [ServiceImplementationMarker]
    public class OrganizationDataDirectoryPathProvider : IOrganizationDataDirectoryPathProvider, IServiceImplementation
    {
        private IOrganizationDirectoryPathProvider OrganizationDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public OrganizationDataDirectoryPathProvider(
            IOrganizationDirectoryPathProvider organizationDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.OrganizationDirectoryPathProvider = organizationDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetOrganizationDataDirectoryPath()
        {
            var organizationDirectoryPath = await this.OrganizationDirectoryPathProvider.GetOrganizationDirectoryPath();

            var dataDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(organizationDirectoryPath, DataDirectory.Name);
            return dataDirectoryPath;
        }
    }
}
