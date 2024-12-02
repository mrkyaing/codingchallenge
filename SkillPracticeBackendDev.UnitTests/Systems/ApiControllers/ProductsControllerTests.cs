using FluentAssertions;
using Moq;
using Microsoft.AspNetCore.Mvc;
using AWebsite.API.Services;
using AWebsite.API.Controllers;
using AWebsite.API.Models;
namespace SkillPracticeBackendDev.UnitTests.Systems.ApiControllers;
public class ProductsControllerTests
{
    private readonly Mock<IProductService> _mockProductService;
    private readonly ProductsController _controller;

    public ProductsControllerTests()
    {
        _mockProductService = new Mock<IProductService>();
        _controller = new ProductsController(_mockProductService.Object);
    }

    [Fact]
    public void GetById_ShouldReturnOk_WhenProductExists()
    {
        // Arrange
        var productId = 1;
        var product = new Product { Id = productId, Name = "Test Product" };
        _mockProductService.Setup(s => s.GetById(productId)).Returns(product);

        // Act
        var result = _controller.GetProductById(productId);

        // Assert
        var okResult = result as OkObjectResult;
        okResult.Should().NotBeNull();
        okResult!.StatusCode.Should().Be(200);
        okResult.Value.Should().BeEquivalentTo(product);
    }

    [Fact]
    public void GetById_ShouldReturnNotFound_WhenProductDoesNotExist()
    {
        // Arrange
        var productId = 1;
        _mockProductService.Setup(s => s.GetById(productId)).Returns((Product)null);

        // Act
        var result = _controller.GetProductById(productId);

        // Assert
        var notFoundResult = result as NotFoundResult;
        notFoundResult.Should().NotBeNull();
        notFoundResult!.StatusCode.Should().Be(404);
    }

    [Fact]
    public void Create_ShouldReturnCreated_WhenProductIsValid()
    {
        // Arrange
        var newProduct = new Product { Name = "New Product" };
        var createdProduct = new Product { Id = 1, Name = "New Product" };
        _mockProductService.Setup(s => s.Create(newProduct)).Returns(createdProduct);

        // Act
        var result = _controller.CreateProduct(newProduct);

        // Assert
        var createdResult = result as CreatedAtActionResult;
        createdResult.Should().NotBeNull();
        createdResult!.StatusCode.Should().Be(201);
        createdResult.ActionName.Should().Be(nameof(ProductsController.GetProductById));
        createdResult.RouteValues["id"].Should().Be(createdProduct.Id);
        createdResult.Value.Should().BeEquivalentTo(createdProduct);
    }

    [Fact]
    public void Create_ShouldReturnBadRequest_WhenModelIsInvalid()
    {
        // Arrange
        _controller.ModelState.AddModelError("Name", "The Name field is required.");

        // Act
        var result = _controller.CreateProduct(new Product());

        // Assert
        var badRequestResult = result as BadRequestObjectResult;
        badRequestResult.Should().NotBeNull();
        badRequestResult!.StatusCode.Should().Be(400);
        badRequestResult.Value.Should().BeAssignableTo<SerializableError>();
    }
}
