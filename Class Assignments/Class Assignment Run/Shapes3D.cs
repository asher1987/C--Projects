using System;
using Shapes;
using Shapes3D;

namespace Shapes3D
{
    public abstract class Shape3D
    {
        //abstract class
        public abstract double GetSurfaceArea(); // method
        public abstract double GetVolume(); // method 
    }

    // First Shape: Cuboid
    class Cuboid: Shape3D 
    {
        public double depth; 
        public double width; 
        public double height;
        

        public Cuboid(double depth, double width, double height)
        {
            this.depth = depth;
            this.width = width; 
            this.height = height; 
        // surface Area of a Cuboid
        //The Surface Area = 2 (dw  + wh + dh) square units 
        }
        

        static double VolumeCuboid(double depth, double width, double height)
        {
            return (depth * height * width);
        }
  
        static double SurfaceAreaCuboid(double depth, double width, double height)
        {
            return (2 * depth * width) + (2 * width * height) + (2 * depth * height);
        }

        public override double GetSurfaceArea()
        {
            return SurfaceAreaCuboid(this.depth, this.width, this.height);
        }

        public override double GetVolume()
        {
            return VolumeCuboid(this.depth, this.width, this.height);
        }
    }
    // 2nd shape: Cube
    class Cube : Cuboid 
        {
            public Cube(double sideLength) : base(sideLength, sideLength, sideLength) {}    
        }

    // 3rd shape: Cylinder
        class Cylinder : Shape3D
    {
        public double radius;
        public double height;


        public Cylinder(double radius, double height)
        {
        this.radius = radius;
        this.height = height; 
        }

        //TotalsurfaceArea = (2 * math.PI * radius * radius) + (2 * Math.PI * height * radius); 

        
        public double VolumeCylinder(double radius, double height)
        {
            return (Math.PI * radius * radius * height);
        }
        
        static double SurfaceAreaCylinder(double radius, double height)
        {
            return (2 * Math.PI * radius * radius) + (2 * Math.PI * height * radius);
        }
         public override double GetVolume()
        {
            return VolumeCylinder(this.radius, this.height);
        }
       
        public override double GetSurfaceArea()
        {
            return SurfaceAreaCylinder(this.radius, this.height);
        }
        
    }

    // 4th shape: Sphere
        class Sphere : Shape3D
    {
        public double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override double GetVolume()
        {
            return(4.0/3.0) * Math.PI * Math.Pow(this.radius, 3);
        }
    
        public override double GetSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
    // 5th shape : Prism
         class Prism : Shape3D 
     {
        public Polygon baseShape;
        public double depth;
        public double height;
        public double width;

        public Prism (double height, double width, double depth) 
        {
            baseShape = new Polygon(height, width);
            this.depth = depth;
            this.height = height; 
            this.width = width; 
        }
        public override double GetSurfaceArea() 
        {
            // Getting the area of both bases
            double baseArea = 2 * baseShape.GetSurfaceArea();
            // Finding the area of the perimeter times the depth
            double sides = baseShape.GetVolume() * this.depth;

            return sides + baseArea;
        }

        public override double GetVolume() 
        {
            return baseShape.GetSurfaceArea() * this.depth;
        }
    }
}
