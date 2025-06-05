using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);       // Lưu một sản phẩm mới
        void DeleteProduct(Product p);     // Xóa một sản phẩm
        void UpdateProduct(Product p);     // Cập nhật một sản phẩm
        List<Product> GetProducts();      // Lấy danh sách tất cả sản phẩm
        Product GetProductById(int id);   // Lấy một sản phẩm theo ID
    }
}
