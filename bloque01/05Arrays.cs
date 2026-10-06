using System.Globalization;

namespace bloque01;

partial class Program
{
    static void LeerArreglos()
    {
        int[]ArrayEnteros=new int[5];
        ArrayEnteros[1]=10;

        int [] OtroArray=[6,4,7,8,10];

        Console.WriteLine(ArrayEnteros[1]);

        for(int i=0; i<OtroArray.Length; i++)
        {
            Console.WriteLine($"El elemento {i} es {OtroArray[i]}");
        }   

        int []PrimerosTresElementos=OtroArray[..3];
        int []desdeCuartoElemento=OtroArray[4..];

        foreach(var elemento in PrimerosTresElementos)
        {
            Console.WriteLine(elemento);
        }

        foreach(var elemento in desdeCuartoElemento)
        {
            Console.WriteLine(elemento);
        }
    }
}