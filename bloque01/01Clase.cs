using System;
using System.Runtime.InteropServices;
namespace bloque01;
partial class Program
{
    static void Clases()
    {
        Vehiculo car1=new Vehiculo();
        car1.Marca="Toyota";
        car1.Modelo="Prius";
        car1.Anio=2024;
        //Console.WriteLine($"El carro es un {car1.Marca}, su modelo es {car1.Modelo} y el año de fabricación es {car1.Anio}");

       car1.MostrarDatos();

       Vehiculo BYD=new Vehiculo{Modelo="Seagull", Marca="BYD", Anio=2025};
       Vehiculo Ford=new Vehiculo("Ford", "Fiesta", 2014);

       BYD.MostrarDatos();
       Ford.MostrarDatos();
    }

    class Vehiculo
    {
        public string? Marca {get; set;}
        public string? Modelo{get; set;}

        public int Anio{get; set;}

        public void MostrarDatos()
        {
             Console.WriteLine($"El carro es un {Marca}, su modelo es {Modelo} y el año de fabricación es {Anio}");

        }
        public Vehiculo(){}
        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca=marca;
            Modelo=modelo;
            Anio=anio;
        }

    }
}