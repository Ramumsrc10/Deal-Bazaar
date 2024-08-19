using PracticeAPI.Entities;
namespace PracticeAPI.Repositories
{
    public interface IOrderRepossitory
    {
        List<Order> GetAllOrdersByUserId(string name);
        void CancelOrder(int id);
        void Add(Order order);
        Order GetOrderByProductName(string name, string userid);

    }
}
