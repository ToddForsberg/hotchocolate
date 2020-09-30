using System.Collections;
using System.Collections.Generic;
using HotChocolate;
using HotChocolate.ApolloFederation;
using HotChocolate.Types;
using Reviews.Data;

namespace Reviews.Models
{
    [ExtendObjectType("product")]
    public class Product
    {
        [Key][External]
        public string Upc { get; set; }

        public IEnumerable<Review> GetReviews([Service] ReviewRepository reviewRepository)
        {
            return reviewRepository.GetByProductUpc(Upc);
        }
    }
}
