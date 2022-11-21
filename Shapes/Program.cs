



public statis void Main(string [] args) {
    string filepath = args[0];
    double total = 0;

    foreach (string Line in System.IO.File.ReadLines(filepath))
    string[] LineData = Line.Split(',');

   Shape myShape; //I have a shape that's called myShape. There is no default value here.
   

   //please use this in the assignment
   switch (LineData[0]) {
    case "circle":
        myShape = new Circle(
            Convert.ToDouble(LineData[2])
        );
        break;
        

   }
    if (LineData[0] == "circle") {
        myShape = newCircle(
            Convert.ToDouble(LineData[2])
        );


        }
    
    else if (LineData[0] == 'rect') {
        myShape = new Rectangle(
            Convert.ToDouble(LineData[2]),
            Convert.ToDouble(LinedData[3])
        );
    }
    else if (LineData[0] == "square") {
        myShape = new Square(
            Convert.ToDouble(LineData[2]),
        );
    }

// how to format a number with only two decimals
{total: 0,0.00}