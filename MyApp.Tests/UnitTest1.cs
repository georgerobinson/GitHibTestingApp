namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Intentionally failing assertion
        Assert.Equal(4, 2 + 2); // Change this to Assert.Equal(5, 2 + 2);
    }

    [Fact]
    public void Test2()
    {
        // Intentionally failing assertion
        Assert.Equal(6, 3 + 3); // Change this to Assert.Equal(5, 2 + 2);
    }
}