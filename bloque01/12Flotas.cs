using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace bloque01;

partial class Program
{
    static void Flotas()
    {
        Bus BMW=new Bus("BMW", "B-200", 2020, 5000, 15_000 );
        Bus Mercedes = new Bus("Mercedes", "M-100", 2024, 6500, 40_000);
        Bus Hino=new Bus("Hino", "H300",2023, 7000, 30_000 );


        Flota flota=new();
        flota.AddBus(BMW);
        flota.AddBus(Mercedes);
        flota.AddBus(Hino);

        flota.ShowFlota();

        BMW.DistanciaManejo(500);
        Mercedes.DistanciaManejo(300);
        Hino.DistanciaManejo(650);

        flota.ShowFlota();
        Hino=BMW;
        Console.WriteLine($"{BMW.GetHashCode()}");

        /*foreach(var unidad in flota)
        {
            unidad.showPrecioBus();
        }*/
    }

    class Bus
    {
        public string? Marca{get; set;}
        public string? Modelo{get; set;}
        public int Anio{ get; set;}
        public double Totalkm {get;set;}
        public double Precio{get; set;}
        public Bus(string marca, string modelo, int anio,  double totalkm, double precio)
        {
            Marca=marca;
            Modelo=modelo;
            Anio=anio;
            Totalkm=totalkm;
            Precio=precio;
        }

        public void DistanciaManejo(double kilometros)
        {
            Totalkm+=kilometros;
        }

        public void showPrecioBus()
        {
            Console.WriteLine($"El precio del Bus Marca{Marca} es {Precio:C}");
        }
    }

 class Flota()
    {
        private List<Bus> buses=new List<Bus>();

        public void AddBus(Bus linea)
        {
            buses.Add(linea);
        }

        public void ShowFlota()
        {
            foreach(var unidad in buses)
            {
                Console.WriteLine($"Marca {unidad.Marca}, modelo {unidad.Modelo}, Año: {unidad.Anio} y km {unidad.Totalkm}");
            }
        }
    }
}