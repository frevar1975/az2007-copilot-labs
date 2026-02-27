using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Controllers;

/// <summary>
/// API controller for managing product catalog operations.
/// Provides endpoints to retrieve and create products.
/// </summary>
public class ProductsController : ControllerBase
{
    /// <summary>
    /// Gets all products from the catalog.
    /// </summary>
    /// <returns>
    /// An IActionResult containing the collection of all products.
    /// Returns 200 OK with the product list.
    /// </returns>
public IActionResult Get()
{
    return Ok();
}

/// <summary>
/// Creates a new product in the catalog.
/// </summary>
/// <param name="product">The product object to be created containing product details.</param>
/// <returns>
/// An IActionResult indicating the result of the creation operation.
/// Returns 201 Created with the newly created product and its location.
/// </returns>
public IActionResult Create(Product product)
{
    product.Id = _products.Count + 1;
    _products.Add(product);
    return CreatedAtAction(nameof(Get), product);
}
}