using System;
using System.Net.Http;
using System.Threading.Tasks;
using CQC.TLey.StructureMap.Lib.Interface;

namespace CQC.TLey.StructureMap.Lib.Impl
{
    public class EgovLogHttpClient : IEgovHttpClient
    {
        public IEgovLogger Logger1 { get; }
        public IEgovLogger Logger2 { get; }

        public EgovLogHttpClient(IEgovLogger logger1, IEgovLogger logger2)
        {
            Logger1 = logger1 ?? throw new ArgumentNullException(nameof(logger1));
            Logger2 = logger2;
        }
        public async Task<string> GetAsync(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}