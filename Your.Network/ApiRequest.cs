using System.Threading.Tasks;
using Your.Network.Models;
using Your.Network.Handlers;
using System.Text.Json;

namespace Your.Network {

    public abstract class ApiRequest<TResult> {

        public async Task<TResult> Execute() {
            return await OnExecute();
        } 

        protected abstract Task<TResult> OnExecute();


        /* Dirty response, may contain error from server */
        protected internal TResult OnServerResponseReceived(string response) {
            Error error = JsonSerializer.Deserialize<Error>(response)!;

            if (error.Message == null)
                return OnResponseSuccess(response);

            throw new ApiException(error);
        }

        /* Handled response, deserialize and pass */
        protected virtual TResult OnResponseSuccess(string response) {
            return JsonSerializer.Deserialize<TResult>(response)!;
        }
    }
}