namespace Backend;

	public class Square : GeometricFigure
    {
	 
	private double _a;

	public Square(string name, double a)
	{
		A = a;
		Name = name;
	}

	public double A
	{
		get => _a;
		set => _a = ValidateA(value);
	}

	public override double GetArea() => Math.Pow(A, 2);

	public override double GetPerimeter() => 4 * A;
	private double ValidateA(double a)
	{
		if (a <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(a), $"The side : {a} is invalid.");
		}
		return a;
	}

}

