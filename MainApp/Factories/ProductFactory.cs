using MainApp.Dtos;
using MainApp.Models;

namespace MainApp.Factories;

public class ProductFactory
{
    public static ProductRegistrationForm Create() => new();

    public static Product Create(ProductRegistrationForm productRegistrationForm) => new();
}
