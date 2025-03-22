using System.Globalization;

namespace GenericsSetDictionary.Entities;

public class Product : IComparable{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price) {
        Name = name;
        Price = price;
    }

    public override string ToString() {
        return $"Name: {Name}; Price: {Price.ToString(CultureInfo.InvariantCulture)}";
    }

    public int CompareTo(object? obj) {
        if (!(obj is Product)) {
            throw new ArgumentException("Comparing error: Argument is not a Product");
        }
        
        Product other = obj as Product;
        
        return Price.CompareTo(other.Price);
    }
}