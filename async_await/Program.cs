using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        public async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");
            
            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");

            return content.Length;
        }
    }
}
