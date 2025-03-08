using WebsiteBanHang.Models;

namespace WebsiteBanHang.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
            {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Smartphone" },
            new Category { Id = 3, Name = "Tablet" },
            new Category { Id = 4, Name = "Mouse" },
            new Category { Id = 5, Name = "Keyboard" },
            };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
