using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Quadia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationDataDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetOrganizationDataDirectoryPath();
    }
}
