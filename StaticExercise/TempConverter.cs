using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		
		
	    public static double FahrenheitToCelsius(double fahenheit)
		{
			return (fahenheit - 32) / 1.8;
            

		}

		
		public static double CelsiusToFahrenheit(double celsius)
	    {
			var result = celsius * 9 / 5 + 32;
			return result;


        }

     }
}

