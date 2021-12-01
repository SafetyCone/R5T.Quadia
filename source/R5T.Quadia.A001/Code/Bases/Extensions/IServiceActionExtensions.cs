using System;

using R5T.Bulgaria.Default;
using R5T.Bulgaria.UserProfileDirectory;
using R5T.Carpathia.Costobocia;
using R5T.Carpathia.Default;
using R5T.Costobocia.Bulgaria;
using R5T.Costobocia.Default;
using R5T.Lombardy;
using R5T.Ostrogothia;
using R5T.Quadia.Carpathia;
using R5T.Visigothia.Default;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Quadia.A001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static IServiceActionAggregation01 AddOrganizationDataDirectoryPathProviderActions(this IServiceAction _,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var userProfileDirectoryPathProviderAction = _.AddUserProfileDirectoryPathProviderAction();
            var dropboxDirectoryNameProviderAction = _.AddDropboxDirectoryNameProviderAction();
            var organizationsDirectoryNameProviderAction = _.AddOrganizationsDirectoryNameProviderAction();
            var organizationDirectoryNameProviderAction = _.AddOrganizationDirectoryNameProviderAction(
                organizationProviderAction);

            var dropboxDirectoryPathProviderAction = _.AddDropboxDirectoryPathProviderAction(
                dropboxDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction);

            var organizationsDirectoryPathProviderAction = _.AddOrganizationsDirectoryPathProviderAction(
                dropboxDirectoryPathProviderAction,
                organizationsDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);

            // Use the shared organization directory.
            // Use organizaztional directory path provider for shared organization directory path provider.
            var organizationalDirectoryPathProviderAction = _.AddOrganizationDirectoryPathProviderAction(
                organizationDirectoryNameProviderAction,
                organizationsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var sharedDirectoryNameProviderAction = _.AddSharedDirectoryNameProviderAction();
            var sharedOrganizationDirectoryPathProviderAction = _.AddSharedOrganizationDirectoryPathProviderAction(
                organizationalDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);
            var organizationDirectoryPathProviderAction = _.ForwardToIOrganizationDirectoryPathProviderAction(
                sharedOrganizationDirectoryPathProviderAction);

            var organizationDataDirectoryPathProviderAction = _.AddOrganizationDataDirectoryPathProviderAction(
                organizationDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new ServiceActionAggregation01
            {
                DropboxDirectoryNameProviderAction = dropboxDirectoryNameProviderAction,
                DropboxDirectoryPathProviderAction = dropboxDirectoryPathProviderAction,
                OrganizationalDirectoryPathProviderAction = organizationalDirectoryPathProviderAction,
                OrganizationDataDirectoryPathProviderAction = organizationDataDirectoryPathProviderAction,
                OrganizationDirectoryNameProviderAction = organizationDirectoryNameProviderAction,
                OrganizationDirectoryPathProviderAction = organizationDirectoryPathProviderAction,
                OrganizationsDirectoryNameProviderAction = organizationsDirectoryNameProviderAction,
                OrganizationsDirectoryPathProviderAction = organizationsDirectoryPathProviderAction,
                SharedDirectoryNameProviderAction = sharedDirectoryNameProviderAction,
                SharedOrganizationDirectoryPathProviderAction = sharedOrganizationDirectoryPathProviderAction,
                UserProfileDirectoryPathProviderAction = userProfileDirectoryPathProviderAction,
            };
        }
    }
}
