namespace bloque01;
partial class Program
{
    static void Variables()
    {
        int intAutonomia=300;
        string sMarca="BYD";
        bool isElectric=true;
        Console.WriteLine($"El Auto con Marca {sMarca} tiene autonomia de  {intAutonomia} y es electrico {isElectric}");

        Console.WriteLine(Int64.MaxValue);

        int TotalMount=35;
        Console.WriteLine($"Total Generado” {TotalMount:C}");
    }
}