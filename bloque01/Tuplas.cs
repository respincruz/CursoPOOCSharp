namespace bloque01;
partial class Program
{
    static void Tupla()
    {
        var operacion=Operation(9,6);
        Console.WriteLine($"La suma es {operacion.Sum} y la resta es {operacion.Resta}");
    }

    static (int Sum, int Resta) Operation(int a, int b)
    {
        return (a+b, a-b);
    }
}