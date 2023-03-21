public class Temperature
{
    private double fahrenheit;

    public double Fahrenheit
    {
       get 
       {
        return fahrenheit;
       }
       set
       {
        double absolutezeroFahreneit = -459.67;
        if (value < absolutezeroFahreneit)
        {
            throw new ArgumentException("Value is below zero");
        }
        fahrenheit = value;
       }
    }
}