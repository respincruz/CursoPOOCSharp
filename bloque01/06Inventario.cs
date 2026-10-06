using System.Globalization;

namespace bloque01;

partial class Program
{
    static void Inventario()
    {
       string [] sProductos={"Camisetas", "Balones", "Raquetas"};
       double [] dPrecios={15.80,25.47,123.30};
       int [] iCantidad={25, 10, 5};
       int iOpcion=1;
        do{ 
            Console.WriteLine("Escoja una de las opciones:");
            Console.WriteLine("1. Menu de Productos");
            Console.WriteLine("2. Salir");
            iOpcion=int.Parse(Console.ReadLine()!);
            if (iOpcion != 2)
            {
                Console.WriteLine("Inventarios de la tienda");
                for(int i=0; i < sProductos.Length; i++)
                {
                    Console.WriteLine($"Producto: {sProductos[i]}\t Precio: {dPrecios[i]}\t Cantidad:{iCantidad[i]}");

                }

                Console.WriteLine("Que producto quiere comprar?");
                string sProductoBusca=(Console.ReadLine()!);
                Console.WriteLine($"Cuant@s {sProductoBusca} quiere comprar?");
                int iPedido=int.Parse(Console.ReadLine()!);

                Boolean flagBandera=false;
                for(int i = 0; i < sProductos.Length; i++)
                {
                    if (sProductos[i].Equals(sProductoBusca, StringComparison.OrdinalIgnoreCase))
                    {
                        if (iCantidad[i]>= iPedido)
                        {
                            double dCompra=iPedido*dPrecios[i];
                            Console.WriteLine($"Su compra es por {dCompra}");
                            iCantidad[i]-=iPedido;
                            Console.WriteLine($"Ahora tienes {iCantidad[i]} de {sProductos[i]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay stock");
                        }
                        flagBandera=true;
                        break;
                    }
                    
                }
                if (flagBandera == false)
                {
                    Console.WriteLine("No existe el producto");
                }
            }
       
        }while(iOpcion!=2);
        Console.WriteLine("Has finalizado la sesion");
    }
}