using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Repositories;
using PracticeAPI.Entities;


namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepossitory OrderRepository;

        public OrderController(IOrderRepossitory orderRepository)
        {
            this.OrderRepository = orderRepository;
        }

        [HttpPost, Route("AddOrder")]
        public IActionResult Add(Order order)
        {
            try
            {
                OrderRepository.Add(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetAllOrdersByUserId/{userid}")]
        public IActionResult GetAllOrdersByUserId(string userid)
        {
            try
            {
                var orders = OrderRepository.GetAllOrdersByUserId(userid);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete, Route("CancelOrder/{id}")]
        public IActionResult CancelOrder(int id)
        {
            try
            {
                OrderRepository.CancelOrder(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetOrderByProductName/{name}/{userid}")]
        public IActionResult GetOrderByProductName(string name, string userid)
        {
            try
            {
                var order = OrderRepository.GetOrderByProductName(name, userid);
                return Ok(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

    }
}
