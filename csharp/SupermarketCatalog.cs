
namespace supermarket
{
    public interface SupermarketCatalog
    {
        void AddProduct(Product product, double price);

        double GetUnitPrice(Product product);

    }
}
