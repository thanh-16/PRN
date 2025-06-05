using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService // Triển khai ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository; // Khai báo field để giữ instance của ICategoryRepository

        // Constructor: Khi CategoryService được tạo, một instance của CategoryRepository sẽ được tạo và gán vào field trên.
        // Đây là một dạng Dependency Injection đơn giản (constructor injection), mặc dù ở đây là khởi tạo trực tiếp.
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories(); // Gọi phương thức từ repository
        }
    }
}
