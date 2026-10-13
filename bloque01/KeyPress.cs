using System.Diagnostics.Metrics;
using System.Runtime;

namespace bloque01;
partial class Program
{
    static void KeyPresiona()
    {
        int count=0;
        Console.WriteLine("Pulsa una tecla");
        while (true)
        {
            var key=Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.WriteLine($"Haz presionado {count} teclas antes de Salir con ESC");
                Console.WriteLine("Fin de Programa");
                break;
            }
            count++;
            int numero=int.Parse(Console.ReadLine()!);
        }
    }
}