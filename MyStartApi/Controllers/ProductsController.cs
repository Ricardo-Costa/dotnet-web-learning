using Microsoft.AspNetCore.Mvc;
using MyStartApi.Basic;


namespace MyStartApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
  private readonly ILogger<ProductsController> _logger;

  public ProductsController(ILogger<ProductsController> logger)
  {
    _logger = logger;
  }

  [HttpGet(Name = "GetProducts")]
  public IEnumerable<Product> Get()
  {
    /* TODO no construtor passando parametros nomeados */
    return Enumerable.Range(1, 5).Select(index => new Product(description: "Notebook description by constructor...")
    {
      Name = "Notebook",
      // Description = "Main notebook product sample", // TODO inacessível pela visibilidade alterada
      CreatedAt = DateTime.Now.AddDays(index),
    })
    .ToArray();
  }
}