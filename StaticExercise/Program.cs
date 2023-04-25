namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Enter a number in fahrenheit that you'd like to convert to celsius");
            var userFahrenheit = double.Parse(Console.ReadLine());
            var celsius = TempConverter.FahrenheitToCelsius(userFahrenheit);
            Console.WriteLine($" Temparature in celcious would be: {celsius} degrees");
            Console.WriteLine();

            
            Console.WriteLine($"Enter a number in celsius that you'd like to conert to fahrenheit");
            var userCelsius = double.Parse(Console.ReadLine());
            var fahrenheit = TempConverter.CelsiusToFahrenheit(userCelsius);
            Console.WriteLine($"Temperature in fahrenheit is {fahrenheit} degrees");
            Console.WriteLine();

            
            

            
            
        }

        
    }
}
