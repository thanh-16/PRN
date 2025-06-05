using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories
{
    public class CategoryRepository : ICategoryRepository // Triển khai interface ICategoryRepository
    {
        // Phương thức này triển khai phương thức GetCategories() từ interface ICategoryRepository
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
    }
}
