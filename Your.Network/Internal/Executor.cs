using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Your.Network.Internal {

    internal class Executor : IDisposable {

        public async Task<string?> GetAsync(string uri) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Timeout = 30000;

            using HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            await using Stream? stream = response.GetResponseStream();

            if (stream == null)
                return null;

            using StreamReader reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        public async Task<string?> PostAsync(string uri, object body) {
            HttpClient client = new HttpClient();
            string json = JsonSerializer.Serialize(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponse = await client.PostAsync(uri, httpContent);
            return await httpResponse.Content.ReadAsStringAsync();
        }

        public void Dispose() { }
    }
}