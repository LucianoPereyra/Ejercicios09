using Ejercicio5.Entidades;

namespace Ejercicio.Datos
{
    public class Repositorio
    {
            private readonly List<Temperatura> temperaturas;

            public Repositorio()
            {
                temperaturas = new List<Temperatura>();
                PopularLista();
            }

            private void PopularLista()
            {
                // Lista inicial opcional para pruebas
                temperaturas.AddRange(new List<Temperatura>()
        {
            new Temperatura(25),
            new Temperatura(30),
            new Temperatura(15),
            new Temperatura(0)
        });
            }

            public void Agregar(Temperatura temperatura)
            {
                if (!EstaRepetida(temperatura.Celsius))

                    Console.WriteLine("Esta temperatura está repetida");

                else
                {
                    temperaturas.Add(temperatura);
                }
            }

            public void Eliminar(Temperatura temperatura)
            {
                temperaturas.Remove(temperatura);
            }

            public int GetCantidad()
            {
                return temperaturas.Count;
            }

            public List<Temperatura> GetLista() => temperaturas;

            public bool EstaRepetida(double celsius)
            {
                return temperaturas.Any(t => t.Celsius == celsius);
            }

            public List<Temperatura> FiltrarPorRango(double minCelsius, double maxCelsius)
            {
                return temperaturas.Where(t => t.Celsius >= minCelsius && t.Celsius <= maxCelsius).ToList();
            }

        public bool ExisteTemperatura(double celsius)
        {
            throw new NotImplementedException();
        }
    }

    }

