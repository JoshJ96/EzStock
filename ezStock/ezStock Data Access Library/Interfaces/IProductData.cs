using ezStock_Data_Access_Library.Models;

namespace ezStock_Data_Access_Library;
public interface IProductData
{
    Task<List<ProductModel>> GetProducts();
    Task InsertProduct(ProductModel product);
}