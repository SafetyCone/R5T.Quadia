using System;

using R5T.Bulgaria;
using R5T.Carpathia;
using R5T.Costobocia;
using R5T.Visigothia;

using R5T.T0063;

using IOrganizationDirectoryPathProvider = R5T.Carpathia.IOrganizationDirectoryPathProvider;
using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Quadia.A001
{
    public interface IServiceActionAggregation01
    {
        IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction { get; set; }
        IServiceAction<IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction { get; set; }
        IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction { get; set; }
        IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction { get; set; }
        IServiceAction<IOrganizationalDirectoryPathProvider> OrganizationalDirectoryPathProviderAction { get; set; }
        IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction { get; set; }
        IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction { get; set; }
        IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction { get; set; }
        IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction { get; set; }
        IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction { get; set; }
        IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction { get; set; }
    }
}
