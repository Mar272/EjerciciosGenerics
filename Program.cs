using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenerics
{

    public class Caja<T>
    {
        public T Contenido { get; set; }

        public void MostrarContenido()
        {
            Console.WriteLine($"La caja contiene: {Contenido}");
        }
    }

    class Program
     {
         static void Main()
         {
             Caja<string> cajaDeTexto = new Caja<string>();
             cajaDeTexto.Contenido = "Mensaje de texto";
             cajaDeTexto.MostrarContenido();

             Caja<int> cajaDeNumero = new Caja<int>();
             cajaDeNumero.Contenido = 123;
             cajaDeNumero.MostrarContenido();
         }
     } 

}
