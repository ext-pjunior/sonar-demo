namespace SonarDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2,2));
    }


    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    public void MyFirstTheory(int value)
    {
        Assert.True(IsOdd(value));
    }


    int Add(int x, int y) => x + y;

    bool IsOdd(int value) => value % 2 == 1;
}