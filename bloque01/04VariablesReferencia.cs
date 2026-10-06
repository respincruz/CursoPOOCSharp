namespace bloque01;
partial class Program
{
    static void Referencia()
    {
        int x=45;
        int y=80;
        x=y;
        Console.WriteLine(x);
        Person persona1=new Person{Nombre="Alicia"};
        Person persona2=new Person{Nombre="Pedro"};

        persona1=persona2;
        Console.WriteLine($"{persona1.Nombre}");
        
    }
    class Person
    {
        public string? Nombre{get; set;}
        
    }
}