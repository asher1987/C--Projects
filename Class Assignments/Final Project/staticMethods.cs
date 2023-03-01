namespace FinalAssignment {
  class StaticMethods {
    public static double CalculateTorque(int horsepower, int horsepowerRPM) {
      return (horsepower * 5252) / horsepowerRPM;
    }

    public static double CalculateAverageMPG(int cityMPG, int highwayMPG) {
      return (cityMPG * .45) + (highwayMPG * .55);
    }
  }
}