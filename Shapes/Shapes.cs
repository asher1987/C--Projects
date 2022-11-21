namespace Shapes {
    abstract class Shape {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Rectangle : Shape {
        public double width; //constructor 
        public double height; //constructor

        public Rectangle(double width, double height) { //a method that is called when try to create this object
            this.width = width;
            this.height = height;
        }

        override public double GetArea() {
            return this.width * this.height;
        }

        public override double GetPerimeter()
        {
            return (2 * this.width) + (2 * this.height);
        }
    }





    class Circle : Shape {
    public double radius;

        public Circle(double radius) {
        this.radius = radius;
        }

    public override double GetArea () {
        return Math.PI * Math.Pow(this.radius, 2);
     }
    public override double GetPerimeter()
    {
        return 2 * Math.PI * (this.radius);
    }
}

    class Square : Rectangle {
        public Square(double length) : base(Length, Length) {}
        }

    }