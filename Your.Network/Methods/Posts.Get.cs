using System.Collections.Generic;
using Your.Network.Models;
using System.Text.Json.Serialization;

/* Mark: https://jsonplaceholder.typicode.com/posts */
namespace Your.Network.Methods.Posts {
    public class Get : ApiMethod<List<Post>> {
        public Get() : base("posts") {}

        // public int UserId { set => AddParam("user_id", value); }
        // public string Filter { set => AddParam("filter", value); }
    }
}