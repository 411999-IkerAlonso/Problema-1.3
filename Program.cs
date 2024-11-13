using Problema_1._2_2C;
//Usamor var porque puede ser varios tipos de objeto
var pack = new Pack(10);
pack.Precio = 100;
//Console.WriteLine(pack.CalcularPrecio());

var suelto = new Suelto(100);
suelto.Precio = 1200;
Producto[] productos = new Producto[2];
productos[0] = pack;
productos[1] = suelto;

double total = 0;//Acumulador del precio total de todos los elementos del arreglo
foreach (var item in productos)
{
    Console.WriteLine(item.ToString());
    total += item.Precio;
}
Console.WriteLine("Total: " + total);