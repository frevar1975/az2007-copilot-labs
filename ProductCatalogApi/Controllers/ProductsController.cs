using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new();

    [HttpGet]
    public IActionResult Get() => Ok(_products);

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
        return CreatedAtAction(nameof(Get), product);
    }
}