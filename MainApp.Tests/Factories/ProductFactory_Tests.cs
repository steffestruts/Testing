using MainApp.Dtos;
using MainApp.Factories;
using MainApp.Models;

namespace MainApp.Tests.Factories;

public class ProductFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnProductRegistrationForm() 
    {
        // arrange - förberedelser

        // act - själva utförandet
        ProductRegistrationForm result = ProductFactory.Create();

        // assert - testdelen, förväntning
        Assert.IsType<ProductRegistrationForm>(result);
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("Test Product", 0)]
    public void Create_ShouldReturnProduct_WhenProductRegistrationFormIsSupplied(string title, decimal price) 
    {
        // Arrange
        ProductRegistrationForm productRegistrationForm = new() { Title = title, Price = price };

        // Act
        Product result = ProductFactory.Create(productRegistrationForm);

        // Assert
        Assert.IsType<Product>(result);
        Assert.Equal(productRegistrationForm.Title, result.Title);
        Assert.Equal(productRegistrationForm.Price, result.Price);
    }
}
