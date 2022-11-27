using Your.Network.Models;

namespace Your.Network.Methods.Database {
    public class Get : ApiMethod<Data> {
        public Get() : base("lib") {}

        // public int UserId { set => AddParam("user_id", value); }
        // public string Filter { set => AddParam("filter", value); }
    }
}