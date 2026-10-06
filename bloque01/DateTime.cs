namespace bloque01;
partial class Program
{
    static void Fechas()
    {
        DateTime ahora=DateTime.Now;
        Console.WriteLine(ahora);

        DateTime Hoy=DateTime.Today;
        Console.WriteLine(Hoy);
        
        Console.WriteLine($"Semana Pasada: {ahora.DayOfWeek}");

        DateTime Fecha=new DateTime(2011,9,30);
        TimeSpan diferencia=DateTime.Now-Fecha;
        Console.WriteLine($"He vivido : {diferencia} dias");

    }
}