using Wcanaam.CleanArchitectureBasic.Domain.Validation;

namespace Wcanaam.CleanArchitectureBasic.Domain.Entities {
    public sealed class Product : Entity {

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }


        public Product(string name, string description, decimal price, int stock) {
            ValidateDomain(name, description, price, stock);
        }

        public Product(int id, string name, string description, decimal price, int stock) {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name, description, price, stock);
        }

        public void Update(string name, string description, decimal price, int stock, int categoryId) {
            ValidateDomain(name, description, price, stock);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 5, "Invalid name, too short, minimum 5 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required");

            DomainExceptionValidation.When(description.Length < 15, "Invalid description, too short, minimum 15 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price value");

            DomainExceptionValidation.When(stock < 0, "Invalid stock value");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;

        }
    }
}
