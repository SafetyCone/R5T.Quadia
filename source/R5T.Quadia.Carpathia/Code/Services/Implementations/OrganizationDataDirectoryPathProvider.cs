using System;
using System.Threading.Tasks;

using R5T.Carpathia;
using R5T.Lombardy;


namespace R5T.Quadia.Carpathia
{
    public class OrganizationDataDirectoryPathProvider : IOrganizationDataDirectoryPathProvider
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
