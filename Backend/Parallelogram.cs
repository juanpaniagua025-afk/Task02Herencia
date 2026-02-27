namespace Backend
{
	public class Parallelogram : Rectangle
	{
		// Fields 
		private double _h;

		public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
		{
			H = h;
		}

		// Propeties
		public double H
		{
			get => _h;
			set => _h = ValidateA(value);
		}

		public override double GetArea() => B * H;

		public override double GetPerimeter() => base.GetPerimeter();
		private double ValidateA(double h)
		{
			if (h < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(h), $"The height : {h} is invalid.");
			}
			return h;
		}

	}
}

	

