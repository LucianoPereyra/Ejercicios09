namespace Ejercicio5.Entidades

{
    public class Temperatura
    {
        public double Celsius { get; set; }
        public double Reaumur => 0.8 * Celsius;
        public double Fahrenheit => 1.8 * Celsius + 32;

        public Temperatura(double celsius)
        {
            Celsius = celsius;
        }
    }
}
