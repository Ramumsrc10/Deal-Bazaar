using PracticeAPI.Entities;

namespace PracticeAPI.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> GetAll();
        List<Product> GetByCategory(string category);
        Product GetByTitle(string name);
    }
}
