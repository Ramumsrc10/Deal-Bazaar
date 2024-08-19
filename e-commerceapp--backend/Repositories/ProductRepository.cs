using Microsoft.Extensions.Hosting;
using PracticeAPI.Entities;
using System.Xml.Linq;

namespace PracticeAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext context;

        public ProductRepository(MyContext context)
        {
            this.context = context;
        }
        public void Add(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex) 
            { 
                throw ex;
            }

        }

        public void Delete(int id)
        {
            try
            {
                var item = context.Products.Find(id);
                context.Products.Remove(item);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetByCategory(string category)
        {
            try
            {
                return context.Products.Where(x => x.category == category).ToList() ;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Product GetByTitle(string name)
        {
            try
            {
                var product = context.Products.SingleOrDefault(x => x.name == name);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
     
        }


        public void Update(Product product)
        {
            try
            {
               context.Products.Update(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
