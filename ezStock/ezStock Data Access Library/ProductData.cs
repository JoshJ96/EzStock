using ezStock_Data_Access_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezStock_Data_Access_Library
{
    public class ProductData : IProductData
    {
        private readonly ISqlDataAccess _db;
        public ProductData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProductModel>> GetProducts()
        {
            string sql = "SELECT * FROM dbo.Products";

            return _db.LoadData<ProductModel, dynamic>(sql, new { });
        }

        public Task InsertProduct(ProductModel product)
        {
            string sql = $"INSERT INTO dbo.Products (Id, Name) VALUES ({product.Id},{product.Name})";

            return _db.SaveData(sql, product);
        }
    }
}
