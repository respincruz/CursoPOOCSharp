namespace bloque01;
partial class Program
{
    static void Calculadora()
    {
        Console.WriteLine("Ingrese el Producto");
        string producto=(Console.ReadLine()!);

        Console.WriteLine("Ingrese el precio:");
        double precio=double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese la cantidad:");
        int cantidad=int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Haz comprado {cantidad} {producto} y tu total de Compra es {cantidad*precio}");
        

    }
}