static void LeerDatos(ref double precio, ref int cantidad )
{
    System.Console.Write("Ingrese precio: ");
    precio = double.Parse(Console.ReadLine());
    System.Console.Write("Ingrese cantidad:");
    cantidad = int.Parse(Console.ReadLine());
}

static double CalcularSubtotal(double precio, int cantidad)
{
    double Subtotal = precio*cantidad;
    return Subtotal;
}

static double CalcularDescuento(double subtotal, double porcDescuento)
{
    return subtotal*porcDescuento;
}

static double CalcularTotal(double subtotal, double dscto)
{
    return subtotal-dscto;
}

Console.WriteLine("Bienvenidos");
double precio=0;
int cantidad = 0;
LeerDatos(ref precio, ref cantidad);

double sub_total = CalcularSubtotal(precio,cantidad);
Console.WriteLine($"Subtotal: {sub_total}");

Double descuento = CalcularDescuento(sub_total, 0.10);
System.Console.WriteLine($"Descuento: {descuento}");

double total = CalcularTotal(sub_total,descuento);
System.Console.WriteLine($"Total: {total}");