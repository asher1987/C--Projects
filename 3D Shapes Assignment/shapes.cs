namespace Shapes {
  public abstract class Shape {
    public abstract double Area();
    public abstract double Perimeter();
  }
  public class Triangle : Shape{
    /* Represents a 2D triangle in any form.

        For each of the parameters, we setup a private value and a public accessor.

    This way, we can filter out any attempts to set the values to non-positive numbers.
    */
    public double sideA {
      get{return sideA;}
      set{if (value > 0) {sideA = value;}}
    }
    public double sideB {
      get{return sideB;}
      set{if (value > 0) {sideB = value;}}
    }
    public double sideC {
      get{return sideC;}
      set{if (value > 0) {sideC = value;}}
    }

    public Triangle(double sideA, double sideB, double sideC) {
      // Checking for positive, non-zero numbers
      string errorMessage = "Every side of the triangle must be a positive, non-negative number. Received a `{0}`";
      if (sideA !> 0) {throw new ArgumentException(string.Format(errorMessage, sideA.ToString()));}
      if (sideB !> 0) {throw new ArgumentException(string.Format(errorMessage, sideB.ToString()));}
      if (sideC !> 0) {throw new ArgumentException(string.Format(errorMessage, sideC.ToString()));}

      this.sideA = sideA;
      this.sideB = sideB;
      this.sideC = sideC;
    }

    public override double Area() {
      /* Returns the area of any triangle given we know the three sides.

      We'll be using "Heron's formula" https://en.wikipedia.org/wiki/Triangle#Heron's_formula

      First step is to calculate the 'semiperimeter' or half the triangles perimeter. We can use our perimeter method and half that.

      Then we plug it into this function where s is our semiperimeter
      sqrt{s(s-a)(s-b)(s-c)}
      */
      double semiPerimeter = this.Perimeter() / 2;
      // Returning our completed math function result
      return Math.Sqrt(
        semiPerimeter
        * (semiPerimeter - this.sideA)
        * (semiPerimeter - this.sideB)
        * (semiPerimeter - this.sideC)
      );
    }

    public override double Perimeter() {
      return this.sideA
        + this.sideB
        + this.sideC;
    }
  }

  public class Polygon : Shape {
    /* Represents a 2D regular polygon.

    https://en.wikipedia.org/wiki/Regular_polygon

    We're measuring our polygon by the length of it's faces instead of apothem for simplicity.

    faceLength and faces are read-only to prevent manipulation
    */
    private double _faceLength;
    public double faceLength {
      get{return _faceLength;}
      set{if (value > 0) {_faceLength = value;}}
    }
    private double _faces;
    public double faces {
      get{return _faces;}
      set{if (value >= 3) {_faces = value;}}
    }

    public Polygon(double sideLength, int faces) {
      // Checking for invalid arguments
      if (sideLength <= 0) {
        throw new ArgumentException($"Side length must be a positive, non-zero number. Received `{sideLength}`");
      }
      if (faces < 3) {
        throw new ArgumentException($"The regular polygon must have at least 3 faces. Received `{faces}`");
      }

      // Setting member variables
      this._faceLength = sideLength;
      this._faces = faces;
    }


    public override double Area() {
      /* Returns the area of our polygon

      https://en.wikipedia.org/wiki/Regular_polygon#Area

      (n/4) * s^2 * cot(pi/n)

			where:
				n: number of sides
				s: side length
      */
      // There is no 'cot' in our math library
			// Cot can be represented as cos/sin, so we'll do that.
      double cosComponent = Math.Cos(Math.PI / this._faces);
      double sinComponent = Math.Sin(Math.PI / this._faces);
      double cotComponent = cosComponent / sinComponent;

      // The rest of the formula is simple enough for a single line
      return (this._faces/4) * Math.Pow(this._faceLength, 2) * cotComponent;
    }

    public override double Perimeter() {
      // Gives the perimeter of the polygon.
      return this._faceLength * this._faces;
    }

        internal double GetArea()
        {
            throw new NotImplementedException();
        }

        internal double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }


}