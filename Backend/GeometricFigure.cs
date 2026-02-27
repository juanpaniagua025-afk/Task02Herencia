namespace Backend;

public abstract class GeometricFigure
{
	// Propeties
	public string Name { get; set; } = null!;

	// Methods
	public abstract double GetArea();
	public abstract double GetPerimeter();

	public override string ToString()
	{
		return base.ToString();
	}
	
}
