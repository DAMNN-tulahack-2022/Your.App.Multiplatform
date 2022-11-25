using System;

namespace Your.Network.Handlers {

    public interface IRequestCallback<in TResult> {
        public void OnSuccess(TResult result);
        public void OnError(ApiException exception);
    }
}