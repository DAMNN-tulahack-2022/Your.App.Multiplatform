using System.Threading.Tasks;
using Your.Network.Internal;

namespace Your.Network {
    public class PostRequest<TResult> : ApiRequest<TResult> {
        private readonly object body;
        private readonly string method;

        public PostRequest(object body, string method) {
            this.body = body;
            this.method = method;
        }

        protected override async Task<TResult> OnExecute() {
            using Executor executor = new Executor();
            string? response = await executor.PostAsync($"{EndPoints.MethodsUri}/{method}", body);
            return OnServerResponseReceived(response ?? "");
        }
    }
}