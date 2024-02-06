namespace GeometryLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void CircleSquare()
    {
        Assert.Equal(Math.PI * 5 * 5, new Circle(5).Square());
        Assert.Equal(Math.PI * 3 * 3, new Circle(3).Square());
    }
    
    [Fact]
    public void TriangleSquare()
    {
        Assert.Equal(6, new Triangle(3,4,5).Square());
    }
    
    [Fact]
    public void RectangleSquare()
    {
        Assert.Equal(10, new Rectangle(5,2).Square());
        Assert.Equal(15, new Rectangle(5,3).Square());
        Assert.Equal(80, new Rectangle(10,8).Square());
    }
    
    [Fact]
    public void TriangleIsRight()
    {
        Assert.True(new Triangle(3,4, 5).IsRight());
        Assert.True(new Triangle(5,4, 3).IsRight());
        Assert.True(new Triangle(4,5, 3).IsRight());
    }
    
    //По хорошему написать бы тесты на проверку существования фигур, но тз об этом не говорит.
}