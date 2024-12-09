using MainApp.Helpers;

namespace MainApp.Tests.Helpers;

public class UniqueIdentifierGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        // Act
        string id = UniqueIdentifierGenerator.Generate();
        // Assert
        Assert.False(string.IsNullOrEmpty(id));
        Assert.True(Guid.TryParse(id, out _));
    }
}