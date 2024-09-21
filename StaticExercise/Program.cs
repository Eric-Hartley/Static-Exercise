namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            double tempInF = 100;

            Console.WriteLine(
                "Degrees C: " +
                System.Math.Round(TempConverter.FahrenheitToCelsius(tempInF), 2)
                );

            double tempInC = 37.78;
            Console.WriteLine(
                "Degrees F: " +
                System.Math.Round(TempConverter.CelsiusToFahrenheit(tempInC), 2)
                );
        }
    }
}
