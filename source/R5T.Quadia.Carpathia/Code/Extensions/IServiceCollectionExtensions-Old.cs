using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Carpathia;
using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Quadia.Carpathia
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationDataDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryPathProvider> organizationDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IOrganizationDataDirectoryPathProvider, OrganizationDataDirectoryPathProvider>()
                .Run(organizationDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDataDirectoryPathProvider> AddOrganizationDataDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryPathProvider> organizationDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<IOrganizationDataDirectoryPathProvider>(() => services.AddOrganizationDataDirectoryPathProvider_Old(
                organizationDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
