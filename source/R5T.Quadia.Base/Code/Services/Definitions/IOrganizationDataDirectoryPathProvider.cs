using System;
using System.Threading.Tasks;


namespace R5T.Quadia
{
    public interface IOrganizationDataDirectoryPathProvider
    {
        Task<string> GetOrganizationDataDirectoryPath();
    }
}
