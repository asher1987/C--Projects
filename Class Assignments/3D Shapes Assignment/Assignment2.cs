using Shapes3D;

namespace Solver {
    static class Solver {
        public static void Main(String[] args) {
            //Tester.Tester.Test();
            //return; 



            string filepath = args[0];
            double total = 0;
            List<Shape3D> ashleyList = new List<Shape3D>(); //empty list I can add things to

            foreach (string line in System.IO.File.ReadLines(filepath)) {
                string[] lineData = line.Split(',');

                Shape3D myShape;

                switch (lineData[0]) {
                    case "cuboid":
                        myShape = new Cuboid(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToDouble(lineData[2]),
                            Convert.ToDouble(lineData[3])
                        );
                    break;

                    case "cylinder":
                        myShape = new Cylinder(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToDouble(lineData[2])
                        );
                    break;

                    case "sphere" :
                        myShape = new Sphere(
                            Convert.ToDouble(lineData[1])
                        );
                    break;

                    case "cube" :
                        myShape = new Cube(
                            Convert.ToDouble(lineData[1])
                        );
                    break;

                    case "prism":
                        myShape = new Prism(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToInt32(lineData[2]),
                            Convert.ToDouble(lineData[3])
                        );
                    break;

                    case "area":
                        foreach(Shape3D shape in ashleyList){
                            total += shape.GetSurfaceArea() * Convert.ToDouble(lineData[1]);
                        }
                    
                        ashleyList.Clear();
                    continue;

                    case "volume":
                        foreach(Shape3D shape in ashleyList){
                            total += shape.GetVolume() * Convert.ToDouble(lineData[1]);
                         }

                        ashleyList.Clear();

                    continue;

                    default:
                        throw new FormatException($"Unable to parse shape from name `{lineData[0]}'");
                
                }
                ashleyList.Add(myShape);


                }

                Console.WriteLine($"Your total measurements are {total:0,0.00}");
        
        }

    }
  
}
