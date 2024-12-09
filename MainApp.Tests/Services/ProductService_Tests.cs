using MainApp.Dtos;
using MainApp.Models;
using MainApp.Services;

namespace MainApp.Tests.Services;

public class ProductService_Tests
{
    private readonly ProductService _productService = new();

    [Fact]
    public void SetNewId_ShouldReturnI1AsId_IfNoProductsExists()
    {
        // Act
        int result = _productService.SetNewId();
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void SetNewId_ShouldReturnI1AsId_IfOneProductExists()
    {
        var product = new Product { Id = 1, Title = "Test Product", Price = 100 };
        _productService.AddProductToList(product);
        // Act
        int result = _productService.SetNewId();
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void AddProductToList_ShouldReturnTrue_WhenProductIsAdded()
    {
        // Arrange
        var product = new Product { Id = 1, Title = "Test Product", Price = 100 };
        // Act
        bool result = _productService.AddProductToList(product);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CreateNewProduct_ShouldReturnTrue_WhenProductIsCreatedSuccessfully() 
    {
        // Arrange
        var productRegistrationForm = new ProductRegistrationForm { Title = "Test Product", Price = 100 };
        // Act
        var result = _productService.CreateNewProduct(productRegistrationForm);
        // Assert
        Assert.True(result);
    }
}
