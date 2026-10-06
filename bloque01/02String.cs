namespace bloque01;
partial class Program
{
    static void Cadenas()
    {
        string Texto1="Hola Instituto";
        string Texto2=" ya es Octubre";
        
      
        Texto1=Texto1.ToLower();
        Texto2=Texto2.ToUpper();
         Texto1+=Texto2;
        Console.WriteLine($"Nuevo Texto: {Texto1}");

    }
}