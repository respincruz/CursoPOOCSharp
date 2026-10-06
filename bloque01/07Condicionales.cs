namespace bloque01;
partial class Program
{
    static void Condicionales()
    {
        
        int edad=19;
        if (edad >= 18)
        {
             Console.WriteLine("Es mayor de edad");
             Console.WriteLine("Ya puede sacar su licencia de manejo");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }
        

        string mensaje=edad>=18?"Mayor de edad":"Menor de edad";
        Console.WriteLine(mensaje);

        int temperatura=27;
        if(temperatura>30)
            Console.WriteLine("Hace mucho calor");
        else if(temperatura>20)
            Console.WriteLine("El clima es agradable");
        else
            Console.WriteLine("Es posible que existan lluvias");

        char diaAbreviado='S';
        string diaCalculado="";
        switch (diaAbreviado)
        {
            case 'L': diaCalculado="Lunes";
            break;
            case 'M': diaCalculado="Martes";
            break;
            case 'X': diaCalculado="Miercoles";
            break;
            case 'J': diaCalculado="Jueves";
            break;
            case 'V': diaCalculado="Viernes";
            break;
            case 'S': diaCalculado="Sabado";
            break;
            case 'D': diaCalculado="Domingo";
            break;
        }  
        Console.WriteLine($"El dia equivalente es {diaCalculado}");

        string nombreDia=diaAbreviado switch
        {
            'L'=>"Lunes",
            'M'=>"Martes",
            'X'=>"Miercoles",
            'J'=>"Jueves",
            'V'=>"Viernes",
            'S'=>"sabado",
            'D'=>"Domingo",
            _=>"Dia No Valido"
        };

        Console.WriteLine($"{nombreDia}");
    }
}