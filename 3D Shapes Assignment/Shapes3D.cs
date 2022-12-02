//create a library of 3D shapes called `Shape3D`. 
//Your library should include an abstract class `Shape3D` that defines methods 
//`GetSurfaceArea` and `GetVolume`.
//Shapes:
//Cuboid (rectangular prism)
//Cube (child of cuboid)
//Cylinder
//Sphere

using Shapes;

namespace Shapes3D
{
    public abstract class Shape3D
    { //abstract class
        public abstract double GetSurfaceArea(); //method
        public abstract double GetVolume(); //method
    }

    //First Shape: Cuboid 
    class Cuboid : Shape3D
    {
        public double depth;
        public double width;
        public double height;

        public Cuboid(double depth, double width, double height)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

        }

        //Surface Area of a Cuboid
        //(TSA) = 2 (lw + wh + lh) square units
        override public double GetSurfaceArea()
        {

            return (2*( this.depth *this.width) + 2*(this.width* this.height) + 2*(this.height*this.depth)); 
        }

        //Volume of a Cuboid
        // length * width * height
        public override double GetVolume()
        {

            return this.depth * this.width * this.height;
        }
    }

    // Second Shape: Cube 
    // This will inherit from Cuboid
    class Cube : Cuboid {
        public Cube(double sideLength) : base(
            width: sideLength, 
            height: sideLength, 
            depth: sideLength) {}
    }

    // Third Shape: Cylinder

    class Cylinder:Shape3D {
        public double radius;
        public double height;

        public Cylinder(double radius, double height) {
            this.radius = radius;
            this.height = height;
        }
    // Surface area of Cylinder
    // 2 * PI * Radius * (Height + Radius)

        public override double GetSurfaceArea() 
        {
            return 2 * Math.PI * this.radius * (this.height + this.radius);
        }
     //Volume of a Cylinder
    // Math.PI * (Radius * Radius) * Height

        public override double GetVolume () 
        {
            return Math.PI * (this.radius* this.radius) * this.height;
        }

    }

        // Fourth Shape: Sphere
         class Sphere : Shape3D 
        {
            public double radius;

            public Sphere( double radius ) {
                this.radius = radius;
            }
        //Volue of Sphere
        // 4/3 * PI * radius * radius * radius 
            public override double GetVolume() 
            {
                return (4.0 / 3 * Math.PI * radius * radius*radius);
            }

            public override double GetSurfaceArea()
            {
                return 4 * Math.PI * Math.Pow(this.radius, 2.00);
            }
        }          

        //5th shape: Prisim 

        class Prism : Shape3D {
        //double sideLength, int faces, double height
        
            public Polygon myBase;
            public double height;

            public Prism(double sideLength, int faces, double height ) {
                this.myBase = new Polygon(sideLength, faces);
                this.height = height;
        }
            public override double GetSurfaceArea () {
                double baseArea= this.myBase.GetArea();
                double sideArea = this.myBase.GetPerimeter() * this.height;

                return (baseArea * 2) + sideArea;
            }
            //volume of a prism 
            //area of the polygon * height
            public override double GetVolume() {
                double height = this.height;
                double baseArea = this.myBase.GetArea();

                return( baseArea * this.height);
            }
            
        }
     }
