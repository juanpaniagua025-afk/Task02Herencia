namespace Backend
{
	public class Rectangle : Square
	{
		// Fields 
		private double _b;

		public Rectangle(string name, double a, double b) : base(name, a)
		{
			B = b;
		}

		// Propeties
		public double B
		{
			get => _b;
			set => _b = ValidateA(value);
		}

		public override double GetArea() => A * B;

		public override double GetPerimeter() => 2 * (A + B);
		private double ValidateA(double b)
		{
			if (b < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(b), $"The length : {b} is invalid.");
			}
			return b;
		}

	}
}

