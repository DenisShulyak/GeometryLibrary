using GeometryLibrary.Abstract;

namespace GeometryLibrary;

/// <summary>
/// Окружность.
/// </summary>
public class Circle : Body
{
    /// <summary>
    /// Инициализирует радиус окружности.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    public Circle(double radius) : base(radius)
    {
    }
    
    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public override double Square() => Math.PI * base.Square();
}