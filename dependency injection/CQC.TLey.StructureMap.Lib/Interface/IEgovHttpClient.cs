using System.Threading.Tasks;

namespace CQC.TLey.StructureMap.Lib.Interface
{
    public interface IEgovHttpClient
    {
        Task<string> GetAsync(string url);
    }
}