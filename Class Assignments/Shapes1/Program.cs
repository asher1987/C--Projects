using Shapes;

namespace Program {
  static class Program {
    public static void Main(string[] args) {
      string filepath = args[0];
      double total = 0;

      foreach (string line in System.IO.File.ReadLines(filepath)) {
        string[] lineData = line.Split(',');

        Shape myShape;

        switch (lineData[0]) {
          case "circle":
            myShape = new Circle(
              Convert.ToDouble(lineData[2])
            );
          break;

          case "rect":
            myShape = new Rectangle(
              Convert.ToDouble(lineData[2]),
              Convert.ToDouble(lineData[3])
            );
          break;

          case "square":
            myShape = new Square(
              Convert.ToDouble(lineData[2])
            );
          break;

          default:
            throw new FormatException($"Unable to parse shape from name {lineData[0]}");
        } // switch


        if (lineData[1] == "area") {
          total += myShape.GetArea();
        } else if (lineData[1] == "perim") {
          total += myShape.GetPerimeter();
        }





      }

      Console.WriteLine($"Your total measurements is {total:0,0.00}");
    }
  }
}
