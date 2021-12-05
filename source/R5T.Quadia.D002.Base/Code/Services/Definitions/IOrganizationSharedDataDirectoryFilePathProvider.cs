using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Quadia.D002
{
    [ServiceDefinitionMarker]
    public interface IOrganizationSharedDataDirectoryFilePathProvider : IServiceDefinition
    {
        Task<string> GetFilePath(string fileName);
    }
}
