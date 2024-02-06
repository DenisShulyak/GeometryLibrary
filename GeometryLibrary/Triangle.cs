using GeometryLibrary.Abstract;

namespace GeometryLibrary;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : Body
{
    /// <summary>
    /// Первая сторона.
    /// </summary>
    private readonly double _parameterA;
    
    /// <summary>
    /// Вторая сторона.
    /// </summary>
    private readonly double _parameterB;
    
    /// <summary>
    /// Инициализирует три стороны триугольника.
    /// </summary>
    /// <param name="parameterA">Первая сторона.</param>
    /// <param name="parameterB">Вторая вторая.</param>
    /// <param name="parameterC">Третья третья.</param>
    public Triangle(double parameterA, double parameterB, double parameterC) : base(parameterC)
    {
        _parameterA = parameterA;
        _parameterB = parameterB;
    }

    /// <summary>
    /// Вычисляет площадь треугольника.
    /// </summary>
    /// <returns></returns>
    public override double Square()
    {
        var p = (_parameterA + _parameterB + _parameter) / 2;
        return Math.Sqrt(p * (p - _parameterA) * (p - _parameterB) * (p - _parameter));
    }

    /// <summary>
    /// Прямоугольный ли треугольник.
    /// </summary>
    /// <returns>Результат True/False</returns>
    public bool IsRight()
    {
        if (_parameterB > _parameterA && _parameterB > _parameter)
            return IsRight(_parameterA, _parameter);
        if (_parameterA > _parameterB && _parameterA > _parameter)
            return IsRight(_parameterB, _parameter);
        return IsRight(_parameterA, _parameterB);
    }

    /// <summary>
    /// Проверяет прямоугольный ли треугольник, сравнивая площадь круга с площадью по признаку прямоуг. треугольника.
    /// </summary>
    /// <param name="parameterA">Первый катет.</param>
    /// <param name="parameterB">Второй катет.</param>
    /// <returns>Результат True/False</returns>
    private bool IsRight(double parameterA, double parameterB) => Square() == new Rectangle(parameterA, parameterB).Square() / 2;
}