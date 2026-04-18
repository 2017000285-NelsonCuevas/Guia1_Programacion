using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===BUZON DE VOZ");
        Console.WriteLine("1 - Ventas");
        Console.WriteLine("2 - Recepcion");
        Console.WriteLine("3 - Direccion");
        Console.WriteLine("4 - Compras");
        Console.WriteLine("Digite una opcion: ");
        string voz = Console.ReadLine();

        if (voz == "1")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE VENTAS");
            Console.WriteLine("Nombre Responsable: EMILIANO CUEVAS");
            Console.WriteLine("Correo: n.cuevas.5adb@gmail.com");
        }
        else if (voz == "2")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE RECEPCION");
            Console.WriteLine("Nombre Responsable: HEIDY ESQUIBEL");
            Console.WriteLine("Correo: heicuevas@resetsa.com");
        }
        else if (voz == "3")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE DIRECCION");
            Console.WriteLine("Nombre Responsable: MELANY CUEVAS");
            Console.WriteLine("Correo: melushcuevas@gmail.com");
        }
        else if (voz == "4")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE COMPRAS");
            Console.WriteLine("Nombre Responsable: NELSON CUEVAS");
            Console.WriteLine("Correo: nicuevas@gmail.com");
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}
}