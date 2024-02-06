using GeometryLibrary.Abstract;

namespace GeometryLibrary;

/// <summary>
/// Прямоугольник.
/// </summary>
public class Rectangle : Body
{
    /// <summary>
    /// Сторона.
    /// </summary>
    private readonly double _length;
    
    /// <summary>
    /// Инициализирует стороны прямоугольника.
    /// </summary>
    /// <param name="length">Первая сторона.</param>
    /// <param name="parameter">Вторая сторона.</param>
    public Rectangle(double length, double parameter) : base(parameter)
    {
        _length = length;
    }

    /// <summary>
    /// Вычисляет площадь прямоугольника.
    /// </summary>
    /// <returns></returns>
    public override double Square() => _parameter * _length;
}