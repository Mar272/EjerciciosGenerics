using System;
using System.Collections.Generic;

namespace EjemploGenerics
{ 
    public class Repositorio<T>
    {
        private List<T> elementos = new List<T>();

        public void Agregar(T item)
        {
            elementos.Add(item);
        }

        public void MostrarTodos()
        {
            foreach (T item in elementos)
            {
                Console.WriteLine(item);
            }
        }

        public int Contar()
        {
            return elementos.Count;
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"Producto: {Nombre}, Precio: {Precio:C}";
        }
    }

    public class Cliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Nombre}, Edad: {Edad}";
        }
    }

    class Program
    {
        static void Main()
        {

            var repoProductos = new Repositorio<Producto>();
            repoProductos.Agregar(new Producto { Nombre = "Manzana", Precio = 1.5 });
            repoProductos.Agregar(new Producto { Nombre = "Pan", Precio = 2.0 });

            Console.WriteLine("Productos:");
            repoProductos.MostrarTodos();

            var repoClientes = new Repositorio<Cliente>();
            repoClientes.Agregar(new Cliente { Nombre = "Ana", Edad = 30 });
            repoClientes.Agregar(new Cliente { Nombre = "Luis", Edad = 45 });

            Console.WriteLine("\nClientes:");
            repoClientes.MostrarTodos();

            Console.WriteLine($"Clientes en el repositorio: {repoClientes.Contar()}");
            Console.WriteLine($"Productos en el repositorio: {repoProductos.Contar()}");


            Console.ReadKey();
        }
    }
}

