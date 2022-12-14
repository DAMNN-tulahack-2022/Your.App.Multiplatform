using System;

namespace Your.Network.Handlers {

    public class ApiCallback<TResult> : IRequestCallback<TResult> {
        private Action<TResult>? onSuccess;
        private Action<string>? onError;


        public ApiCallback<TResult> OnSuccess(Action<TResult> success) {
            this.onSuccess = success;
            return this;
        }
        public ApiCallback<TResult> OnError(Action<string> error) {
            this.onError = error;
            return this;
        }


        void IRequestCallback<TResult>.OnSuccess(TResult result) {
            this.onSuccess?.Invoke(result);
        }

        void IRequestCallback<TResult>.OnError(ApiException exception) {
            this.onError?.Invoke(exception.ErrorMessage ?? exception.Message);
        }
    }
}