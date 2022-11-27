using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Your.Network.Models;
using Your.Network.Internal;

namespace Your.Network {

    public class AuthRequest : ApiRequest<Auth> {
        private readonly string login;

        public AuthRequest(string login) {
            this.login = login;
        }

        protected override async Task<Auth> OnExecute() {
            using Executor executor = new Executor();
            string? response = await executor.PostAsync(EndPoints.AuthUri, new AuthBody(login));
            return OnServerResponseReceived(response ?? "");
        }

        private class AuthBody {
            [JsonPropertyName("login")] public string Login { get; set; }

            public AuthBody(string login) {
                Login = login;
            }
        }
    }
}