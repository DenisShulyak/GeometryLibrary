namespace GeometryLibrary.Abstract;

/// <summary>
/// Базовая фигура на основе квадрата.
/// </summary>
public abstract class Body
{
    /// <summary>
    /// Отличительный параметр.
    /// </summary>
    protected readonly double _parameter;
    
    /// <summary>
    /// Конструктор фигуры инициализирующий параметр.
    /// </summary>
    /// <param name="parameter">Отличительный параметр.</param>
    protected Body(double parameter)
    {
        _parameter = parameter;
    }
    
    /// <summary>
    /// Базовая реализация нахождения площади фигуры.
    /// </summary>
    /// <returns></returns>
    public virtual double Square() => Math.Pow(_parameter, 2);
}