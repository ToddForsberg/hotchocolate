using HotChocolate.ApolloFederation;

namespace Products.Models
{
    public class Product
    {
        [Key]
        public string Upc { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
    }
}
