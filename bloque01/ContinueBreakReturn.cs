namespace bloque01;
partial class Program
{
    static void Ruptura()
    {
        string[] Nombres={"Maria", "Jose", "Pedro", "Marcelo", "Juan"};
        for(int i = 0; i < Nombres.Length; i++)
        {
            CalculaLongitud(Nombres[i]);
        }
        /*for(int i=0; i<Nombres.Length; i++)
        {
            if (Nombres[i].Length > 6)
            {
                Console.WriteLine("Condicion para salir");
               // break;
               continue;
            }
            else
            {
                Console.WriteLine($"{Nombres[i]} tiene {Nombres[i].Length} letras");
            }
            Console.WriteLine("Continuacion");
        }*/

    }

    static void CalculaLongitud(string Cadena)
    {
        if(Cadena.Length>6)
            return;
        else
            for(int i=0; i<Cadena.Length; i++)
                Console.Write(Cadena.Substring(i,1));
    }
}