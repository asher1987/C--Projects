namespace Shapes {
	abstract class Shape {
		public abstract double GetArea();
		public abstract double GetPerimeter();
	}

	class Rectangle : Shape {
		public double width;
		public double height;

		public Rectangle(double width, double height) {
			this.width = width;
			this.height = height;
		}

		override public double GetArea() {
			/* Returns the area of the rectangle.

			https://en.wikipedia.org/wiki/Rectangle
			*/
			return this.width * this.height;
		}

		public override double GetPerimeter() {
			return (2 * this.width) + (2 * this.height);
		}
	}

	class Square : Rectangle {
		public Square(double length) : base(length, length) {}
	}

	class Circle : Shape {
		public double radius;

		public Circle(double radius) {
			this.radius = radius;
		}

		public override double GetArea() {
			return Math.PI * Math.Pow(this.radius, 2);
		}

		public override double GetPerimeter()
		{
			return 2 * Math.PI * this.radius;
		}
	}
}