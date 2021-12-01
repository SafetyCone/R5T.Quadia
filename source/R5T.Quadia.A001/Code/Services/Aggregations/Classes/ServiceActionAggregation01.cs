using System;

using R5T.Bulgaria;
using R5T.Carpathia;
using R5T.Costobocia;
using R5T.Visigothia;

using R5T.T0063;


namespace R5T.Quadia.A001
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction { get; set; }
        public IServiceAction<R5T.Carpathia.IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction { get; set; }
        public IServiceAction<Costobocia.IOrganizationDirectoryPathProvider> OrganizationalDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction { get; set; }
        public IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction { get; set; }
    }
}
