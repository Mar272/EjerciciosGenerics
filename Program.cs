using System;
namespace EjemploGenerics
{
    public class Bolsa<T>
    {
        public T Contenido { get; set; }

        public void MostrarContenido()
        {
            Console.WriteLine($"El contenido de la bolsa es: {Contenido}");
        }
    }

    // Asegúrate de que la clase Ejemplo2 tenga el método Main
    class Program
    {
        static void Main()
        {

            Bolsa<string> nombreDeFruta = new Bolsa<string>();
            nombreDeFruta.Contenido = "Manzana";
            nombreDeFruta.MostrarContenido();

            Bolsa<bool> validaElContenido = new Bolsa<bool>();
            validaElContenido.Contenido = true;
            validaElContenido.MostrarContenido();

            Bolsa<int> cantidadDeFruta = new Bolsa<int>();
            cantidadDeFruta.Contenido = 5;
            cantidadDeFruta.MostrarContenido();

            Console.ReadKey();
        }
    }
}
