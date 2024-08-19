using Microsoft.EntityFrameworkCore;
using PracticeAPI.Entities;

namespace PracticeAPI.Repositories
{
    public class OrderRepository : IOrderRepossitory
    {
        private readonly MyContext context;

        public OrderRepository(MyContext context)
        {
            this.context = context;
        }
        public void Add(Order order)
        {
            try
            {
                var ord = new Order
                {
                    OrderId = order.OrderId,
                    OrderDate = order.OrderDate,
                    UserId = order.UserId,
                    ProductId = order.ProductId,
                    Quantity = order.Quantity,
                };
                context.Orders.Add(ord);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CancelOrder(int id)
        {
            try
            {
                var item = context.Orders.Find(id);
                context.Orders.Remove(item);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Order> GetAllOrdersByUserId(string userid)
        {
            try
            {
                return context.Orders.Where(o=> o.UserId == userid).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Order GetOrderByProductName(string name, string userid)
        {
            try
            {
                var item = context.Orders
                    .Include(o => o.Product)
                    .Include(o => o.User).SingleOrDefault(o => o.Product.name == name && o.UserId == userid);
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
