using Natulea.Models;
using System.Threading.Tasks;

namespace Natulea.Services
{
    public interface IAzurEKTPDataStoreIDataStore<T>
    {
        Task<Content> GetEKTPItemAsync(string nik);
    }
}
