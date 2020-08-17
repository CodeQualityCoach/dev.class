using System.Net.Http;
using System.Threading.Tasks;
using CQC.TLey.StructureMap.Lib.Interface;

namespace CQC.TLey.StructureMap.Lib.Impl
{
    public class EgovHttpClient : IEgovHttpClient
    {
        public async Task<string> GetAsync(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}