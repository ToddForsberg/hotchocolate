using HotChocolate.ApolloFederation;
using HotChocolate.Types;

namespace Inventory.Models
{
    [ExtendObjectType("product")]
    public class Product
    {
        [Key][External]
        public string Upc { get; set; }

        [External]
        public int Weight { get; set; }

        [External]
        public int Price { get; set; }

        // TODO: __resolveReference, where this data is filled by a repository
        public bool InStock { get; set; }

        [Requires("price weight")]
        public int GetShippingEstimate()
        {
            // free for expensive items, else the estimate is based on weight
            return Price > 1000 ? 0 : (int) (Weight * 0.5);
        }
    }
}
