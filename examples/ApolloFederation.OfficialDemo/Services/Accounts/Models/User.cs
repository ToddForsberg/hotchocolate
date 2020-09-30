using System.Security.Cryptography;
using HotChocolate.ApolloFederation;

namespace Accounts.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
    }
}
