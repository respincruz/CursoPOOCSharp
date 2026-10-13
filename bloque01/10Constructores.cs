using System.Data;

namespace bloque01;
partial class Program
{
    static void Constructores()
    {
        Carro BMW=new Carro();
        BMW.Marca="BMW";
        BMW.Anio=2025;
        Carro Mazda=new Carro{Marca="Mazda", Anio=2024};

        BMW.ShowData();
        Mazda.ShowData();

    }
    class Carro
    {
        public string? Marca {get; set;}
        public int? Anio{get; set;}

        public void SetMarca(string marca)
        {
            Marca=marca;
        }

        public string MostrarInfo()
        {
            return $"Automovil Marca {Marca}, su Año es {Anio}";
        }
        public void ShowData()
        {
            Console.WriteLine(MostrarInfo());
        }

        // constructor por parametros
        public Carro(string marca, int anio)
            {
                Marca=marca;
                Anio=anio;
            }
            //Constructor por defecto
            public Carro()
        {
            
        }
        ~Carro()
        {
            Console.WriteLine("Invocacion a Destructor");
            //ConnectionState.Close();
        }
    }

    
}