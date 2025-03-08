using System.Collections.Generic;
using System.Linq;
using WebsiteBanHang.Models;
public class MockProductRepository : IProductRepository
{
    private readonly List<Product> _products;
    public MockProductRepository()
    {
        // Tạo một số dữ liệu mẫu
        _products = new List<Product>
        {
            new Product { Id = 1, Name = "Elysia", Price = 10000000, Description = "Jesus Christ of Honkai Impact", ImageUrl = "/images/Elysia.webp"},
            new Product { Id = 2, Name = "Firefly", Price = 500000, Description = "Fan service mạnh nhất lịch sử", ImageUrl = "/images/Firefly.webp" },
            new Product { Id = 3, Name = "Furina", Price = 3000000, Description = "Thần của Teyvat, Thần dương", ImageUrl = "/images/Furina.webp" },
            new Product { Id = 4, Name = "Yotsuba", Price = 200000, Description = "Tout le monde, c'est ma femme.", ImageUrl = "/images/Yotsuba.png" },
            new Product { Id = 5, Name = "Keqing", Price = 15000000, Description = "Tout le monde, c'est ma femme + 1", ImageUrl = "/images/Keqing.jpg" },
            new Product { Id = 6, Name = "Tribbie", Price = 800000, Description = "Dũng cảm vượt qua vạn cánh cửa", ImageUrl = "/images/Tribbie.webp" },
            new Product { Id = 7, Name = "Castorice", Price = 120000, Description = "Siêu cấp hướng nội", ImageUrl = "/images/Castorice.webp" },
            new Product { Id = 8, Name = "Kokona", Price = 1005600, Description = "AwP vĩ đại nhất lịch sử P.U.S", ImageUrl = "/images/kokona.webp" }

        };
    }
    public IEnumerable<Product> GetAll()
    {
        return _products;
    }
    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
    public void Add(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
    }
    public void Update(Product product)
    {
        var index = _products.FindIndex(p => p.Id == product.Id);
    
        if (index != -1)
        {
            _products[index] = product;
        }
    }
    public void Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}