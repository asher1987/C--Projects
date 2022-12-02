using Shapes3D;

namespace Solver {
    static class Solver {
        public static void Main(string[] args) {
            //Tester.Tester.Test();
            //return; 



            string filepath = args[0];
            double total = 0;

            foreach (string line in System.IO.File.ReadLines(filepath)) {
                string[] lineData = line.Split(',');

                Shape3D myShape;

                switch (lineData[0]) {
                    case "cuboid":
                        myShape = new Cuboid(
                            Convert.ToDouble(lineData[2]),
                            Convert.ToDouble(lineData[3]),
                            Convert.ToDouble(lineData[4])
                    );
                    break;

                    case "cylinder":
                        myShape = new Cylinder(
                            Convert.ToDouble(lineData[2]),
                            Convert.ToDouble(lineData[3])
                    );
                    break;

                    case "sphere" :
                        myShape = new Sphere(
                            Convert.ToDouble(lineData[2])
                    );
                    break;

                    case "cube" :
                        myShape = new Cube(
                            Convert.ToDouble(lineData[2])
                    );
                    break;

                    case "Prism":
                        myShape = new Prism(
                            Convert.ToDouble(lineData[2]),
                            Convert.ToInt32(lineData[3]),
                            Convert.ToDouble(lineData[4])
                    );
                    break;

                    default:
                        throw new FormatException($"Unable to parse shape from name {lineData[0]}");
                 

                }

                if (lineData[1] == "area") {
                    total += myShape.GetSurfaceArea();
                } else if (lineData[1] == "volume") {
                    total += myShape.GetVolume();


                }

            
            }
        Console.WriteLine($"Your total measurements are {total:0,0.00}");

        }
  
    }
}