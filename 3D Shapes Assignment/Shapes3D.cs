//create a library of 3D shapes called `Shapes3D`. 
//Your library should include an abstract class `Shape3D` that defines methods 
//`GetSurfaceArea` and `GetVolume`.
//Shapes:
//Cuboid (rectangular prism)
//Cube (child of cuboid)
//Cylinder
//Sphere

namespace Shape3D
{
    abstract class Shapes3D
    { //abstract class
        public abstract double GetSurfaceArea(); //method
        public abstract double GetVolume(); //method
    }

    //First Shape: Cuboid 
    class Cuboid : Shapes3D
    {
        public double depth;
        public double width;
        public double height;

        public Cuboid(double width, double depth, double height)
        {
            this.depth = width;
            this.height = height;
            this.depth = depth;

        }

        //Surface Area of a Cuboid
        //(TSA) = 2 (lw + wh + lh) square units
        override public double GetSurfaceArea()
        {

            return 2 * (this.depth * this.width + this.depth * this.height + this.height * this.width);

        }

        //Volume of a Cuboid
        // length * width * height
        public override double GetVolume()
        {

            return this.depth * this.width * this.height;
        }
    }

    // Second Shape: Cube 
    class Cube : Shapes3D
    {
        public double side;

        public Cube(double side)
        {
            this.side = side;
        }

        //Surface area of a cube 
        // edge * edge * edge
        override public double GetSurfaceArea()
        {
            return this.side * this.side * this.side;
        }

        //Volume of a cube
        // side * side * side
        override public double GetVolume()
        {
            return side * side * side;
        }
    }
 // Third Shape: Cylinder 
    
    class Cylinder : Shapes3D
    {
        public double radius;

        public Cylinder (double radius) {
            this.radius = radius;
        }
        public double height;

        public Cylinder (double height) {
            this.height = height;
        }
    // Surface area of Cylinder
    // 2 * PI * Radius * (Height + Radius)



     //Volume of a Cylinder
    // Math.PI * (Radius * Radius) * Height


    }


  
            
}
             // Fourth Shape: Sphere
     
           

                //Volue of Sphere
                // 4/3 * PI * radius * radius * radius 
          

     