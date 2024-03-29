﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Carpathia;
using R5T.Lombardy;

using R5T.T0063;


namespace R5T.Quadia.Carpathia
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDataDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationDataDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryPathProvider> organizationDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IOrganizationDataDirectoryPathProvider, OrganizationDataDirectoryPathProvider>();

            return services;
        }
    }
}
