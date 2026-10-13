using System.Globalization;
using System.Runtime.CompilerServices;

namespace bloque01;

partial class Program
{
    static void ManejoInventario()
    {
        Inventario lista_productos=new();
        Product laptop=new Product("Laptop",800,20);
        Product mouse=new Product("Mouse", 10, 30);

        lista_productos.AddProducto(laptop);
        lista_productos.AddProducto(mouse);
        lista_productos.ShowInventario();
        laptop.Venta(3);
        mouse.Venta(5);
        lista_productos.ShowInventario();


    } 
}

class Product
{
    public string? Nombre{get; set;}
    public double? Precio{get; set;}
    public int Stock{get;set;}

    public Product(string nombre, double precio, int stock)
    {
        Nombre=nombre;
        Precio=precio;
        Stock=stock;
    }
    public void ShowDatos()
    {
        Console.WriteLine($"El Producto {Nombre} cuesta {Precio} y tenemos {Stock} articulos");
    }

    public void Venta(int Cantidad)
    {
        if (Cantidad <= Stock)
        {
            Console.WriteLine($"Venta Exitosa de {Cantidad} del Producto {Nombre}");
            Stock-=Cantidad;
            //return true;
        }
        else
        {
            Console.WriteLine($"Stock insuficiente de {Nombre}");
            //return false;
        }
    }

   
}

 class Inventario
    {
        private List<Product> products=new List<Product>();
        public void AddProducto(Product product)
        {
            products.Add(product);
        }
        public void ShowInventario()
        {
            Console.WriteLine("Lista de Productos");
            foreach(var item in products)
            {
                item.ShowDatos();
            }
        }
    }