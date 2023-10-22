using Food.Entities;
using Food.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : MoldController<Order, OrderRepository>
{
    public OrderController(OrderRepository repository) : base(repository) { }
}