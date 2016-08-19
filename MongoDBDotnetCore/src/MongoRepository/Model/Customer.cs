using System.Collections.Generic;

namespace MongoRepository.Model
{
    public class Customer: Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Product> Products { get; set; }
        public Customer()
        {
            this.Products = new List<Product>();
        }
    }
}
