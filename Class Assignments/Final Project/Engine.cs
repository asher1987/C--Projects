// Please make a selection:
// (1) Add filter for Maximum cost
// (2) Add filter for Minimum seats
// (3) Add filter for Minimum range
// (4) Add filter for Minimum power
// (5) Add filter for Four Wheel Drive
// (6) Find vehicles with given filters
// : <user_input>

// Engine ID,Engine Name,Cylinders,Engine size (L),
// Horsepower (HP),Horsepower (rpm),Valves,Cam type,
// Drive type,Transmission,Engine type,City MPG,Highway MPG,Weight (lbs)

// Engine's track if it's four wheel drive, this should be stored as a boolean
// An engine's torque can be calculated using the provided static function inside staticMethods.cs
using FinalAssignment;

namespace EngineLibrary
{
    public class Engine
    {
        //member variables
        public string Cylinders;
        public bool fourWheelDrive;
        public int engineWeight, engineID, horsepower, horsepowerRPM, cityMPG, highwayMPG;
        public double torque, averageMPG;

        //creating a constructor for engine
        public Engine (int engineID, bool fourWheelDrive, int engineWeight, 
        int horsepower, int horsepowerRPM,int cityMPG, int highwayMPG, string Cylinders){
            this.engineID = engineID;
            this.fourWheelDrive = fourWheelDrive;
            this.engineWeight = engineWeight;
            this.horsepower = horsepower;
            this.horsepowerRPM = horsepowerRPM;
            this.cityMPG = cityMPG;
            this.highwayMPG = highwayMPG;
            this.Cylinders = Cylinders;

        }
    }

    static class EngineRead {
    //reading in the engines
   // create a static method
        
        static public void engineFile(){
            // reference the name of the file you're wanting to read. It can be hard coded.
        }
        // should read this information from the engine.csv file
    }

}








    
