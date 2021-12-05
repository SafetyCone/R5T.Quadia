using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0063;


namespace R5T.Quadia.D002.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationSharedDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationSharedDataDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationSharedDataDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction)
        {
            services
                .Run(organizationDataDirectoryPathProviderAction)
                .AddSingleton<IOrganizationSharedDataDirectoryPathProvider, OrganizationSharedDataDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationSharedDataDirectoryFilePathProvider"/> implementation of <see cref="IOrganizationSharedDataDirectoryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationSharedDataDirectoryFilePathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationSharedDataDirectoryPathProvider> organizationSharedDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationSharedDataDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IOrganizationSharedDataDirectoryFilePathProvider, OrganizationSharedDataDirectoryFilePathProvider>();

            return services;
        }
    }
}