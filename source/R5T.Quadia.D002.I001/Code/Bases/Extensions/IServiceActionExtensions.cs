using System;

using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Quadia.D002.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationSharedDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationSharedDataDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationSharedDataDirectoryPathProvider> AddOrganizationSharedDataDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IOrganizationSharedDataDirectoryPathProvider>(services => services.AddOrganizationSharedDataDirectoryPathProvider(
                organizationDataDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationSharedDataDirectoryFilePathProvider"/> implementation of <see cref="IOrganizationSharedDataDirectoryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationSharedDataDirectoryFilePathProvider> AddOrganizationSharedDataDirectoryFilePathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationSharedDataDirectoryPathProvider> organizationSharedDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOrganizationSharedDataDirectoryFilePathProvider>(services => services.AddOrganizationSharedDataDirectoryFilePathProvider(
                organizationSharedDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
