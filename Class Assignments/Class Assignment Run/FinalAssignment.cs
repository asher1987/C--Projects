using System;
using Shapes3D;

namespace FinalAssignment
{
    internal static class FinalAssignment
    {
        static void Main(string[] args)
        {
            //Create another library called FinalAssignment
            //implement a static class Solver that 
            //read in a csv file containing 3D shapes and their measurements.

            // path to the csv file'

            //For each shape, add the shape to a list of shapes. When the file requests a calculation, iterate through your list to add up the sum of that measurement. In addition, each line will include a integer to scale those results by.
            string path = args[0];
            double total = 0;

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                //cuboid,volume,4.5007,1.0388,4.5548
                // columns[0]
                Shape3D shape;

                if (columns[0] == "cuboid") // 1st 
                {
                    shape = new Cuboid(

                       Convert.ToDouble(columns[1]),
                       Convert.ToDouble(columns[2]),
                       Convert.ToDouble(columns[3])
                    );
                    
                }
                else if (columns[0] == "cube") // 2nd
                {
                    shape = new Cube(

                       Convert.ToDouble(columns[1])
                    );
                    
                }
                
                    //  throw new FormatException($"unable to parse shape from name {columns[0]}");
                    // continue;
                else if (columns[0] == "cylinder") // 3rd
                {
            
                shape = new Cylinder(

                    Convert.ToDouble(columns[1]),
                    Convert.ToDouble(columns[2])
                    );
                   
                }
            
                
            
                else if (columns[0] == "sphere") // 4th
                {
                    shape = new Sphere(

                    Convert.ToDouble(columns[1])    
                    );
                }

                else if (columns[0] == "prism") // 5th 
                {
                    shape = new Prism
                    (
                
                        Convert.ToDouble(columns [1]),
                        Convert.ToInt32(columns [2]),
                        Convert.ToDouble(columns[3])
                    );
                }
                else 
                { 
                throw new FormatException($"unable to parse shape from name {columns[0]}");
                }
                       
                if (columns[0] == "volume") // volume
                {
                total += shape.GetVolume();
                }   
                
                else if (columns[0] == "area") // area 
                {
                    total += shape.GetSurfaceArea();
                
                } 
                Console.WriteLine($"Your total measurements is {total:0,0.00}");
            }
        }     
    }
}



