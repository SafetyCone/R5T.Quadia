using System;

using R5T.Carpathia;
using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Quadia.Carpathia
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDataDirectoryPathProvider> AddOrganizationDataDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationDirectoryPathProvider> organizationDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOrganizationDataDirectoryPathProvider>(services => services.AddOrganizationDataDirectoryPathProvider(
                organizationDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
