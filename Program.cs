using System;

//abstracto
abstract class Figura
{
    public float area;
    public abstract void CalcularArea();
}

class Cuadrado : Figura
{
    public override void CalcularArea()
    {
        float lado;
        Console.WriteLine("Ingrese la longitud del lado 1: ");
        lado = float.Parse(Console.ReadLine());
        area = lado * lado;
        Console.WriteLine($"El area es: {area}");

    }
}

class Circulo : Figura
{
    public override void CalcularArea()
    {
        float radio;
        float pi = 3.14f;
        Console.WriteLine("Ingrese el radio del circulo: ");
        radio = float.Parse(Console.ReadLine());
        area = pi * radio * radio;
        Console.WriteLine($"El area es: {area}");
    }
}

class Triangulo : Figura
{
    public override void CalcularArea()
    {
        float basetri;
        float altura;
        Console.WriteLine("Ingrese la base del triangulo: ");
        basetri = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triangulo: ");
        altura = float.Parse(Console.ReadLine());
        area = (basetri * altura) / 2;
        Console.WriteLine($"El area es: {area}");
    }
}

abstract class Empleado
{
    public string Nombre;
    public float SueldoBase;

    public Empleado(string N, float SB)
    {
        Nombre = N;
        SueldoBase = SB;
    }
    public abstract void CalcularSueldo();

}

class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string N, float SB) : base(N, SB) { }
    public override void CalcularSueldo()
    {
        Console.WriteLine("Bono de presentismo: ");
        float bonoPresentismo = float.Parse(Console.ReadLine());
        float sueldo = SueldoBase + bonoPresentismo;
        Console.WriteLine($"Empleado: {Nombre}");
        Console.WriteLine($"El sueldo es: {sueldo}");
    }
}

class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string N, float SB) : base(N, SB) { }
    public override void CalcularSueldo()
    {
        Console.WriteLine("Ingrese las horas extras que realizo: ");
        int horasSemanales = int.Parse(Console.ReadLine());
        if (horasSemanales > 20)
        {
            Console.WriteLine("Ingrese el monto del bono: ");
            float bono = float.Parse(Console.ReadLine());
            float Sueldo = SueldoBase + bono;
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"El sueldo es: {Sueldo}");
        }
        else
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"El sueldo es: {SueldoBase}");
        }
    }
}

abstract class Vehiculo
{
    public abstract void Arrancar();
    public void Acelerar()
    {
        Console.WriteLine("El vehiculo esta acelerando");
    }
}

class Auto : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine("El auto esta arrancando");
    }
    public void Acelerar()
    {
        Console.WriteLine("El auto esta acelerando");
    }
}

class Moto : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine("La moto esta arrancando");
    }
    public void Acelerar()
    {
        Console.WriteLine("La moto esta acelerando");
    }
}

class Camion : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine("El camion esta arrancando");
    }
    public void Acelerar()
    {
        Console.WriteLine("El camion esta acelerando");
    }
}

abstract class museo
{
    public abstract void Sonido();
}

class Perro : museo
{
    public override void Sonido()
    {
        Console.WriteLine("El perro esta haciendo sonido..");
    }
}

class Lobo : museo
{
    public override void Sonido()
    {
        Console.WriteLine("El lobo esta haciendo sonido..");
    }
}

class Pato : museo
{
    public override void Sonido()
    {
        Console.WriteLine("El pato esta haciendo sonido..");
    }
}

class oveja : museo
{
    public override void Sonido()
    {
        Console.WriteLine("La oveja esta haciendo sonido..");
    }
}

// intefaces
interface Iexportable
{
    void Exportar(string contenido);
}

class ExportarExcel : Iexportable
{
    public void Exportar(string contenido)
    {
        Console.WriteLine("Exportando la informacion como excel.");
    }
}

class ExportarPDF : Iexportable
{
    public void Exportar(string contenido)
    {
        Console.WriteLine("Exportando la informacion como PDF.");
    }
}

class ExportarCSV : Iexportable
{
    public void Exportar(string contenido)
    {
        Console.WriteLine("Exportando la informacion como CSV.");
    }
}

interface IVehiculo
{
    void conducir();
}

class IAuto : IVehiculo
{
    public void conducir()
    {
        Console.WriteLine("El auto se esta conduciendo");
    }
}

class IMoto : IVehiculo
{
    public void conducir()
    {
        Console.WriteLine("La moto se esta conduciendo");
    }
}

class IBicicleta : IVehiculo
{
    public void conducir()
    {
        Console.WriteLine("La bicicleta se esta conduciendo");
    }
}

interface Peticiones
{
    void GET(int id);
    void POST(string nuevo);
    void PUT(int id, string cambio);
    void DELETE(int id);
}

class usuario : Peticiones
{
    public void GET(int id)
    {
        Console.WriteLine($"Obteniendo informacion del id: {id}");
    }
    public void POST(string nuevo)
    {
        Console.WriteLine($"Creando nuevo registros, datos: {nuevo}");
    }
    public void PUT(int id, string cambio)
    {
        Console.WriteLine($"Actualizando el id {id} con la informacion: {cambio}");
    }
    public void DELETE(int id)
    {
        Console.WriteLine($"Eliminando el id: {id}");
    }
}
class program
{
    static void Main()
    {
        Console.WriteLine("Metodos abstractos");
        Console.WriteLine("");
        Console.WriteLine("Figuras");
        Console.WriteLine("");
        Cuadrado C = new Cuadrado();
        C.CalcularArea();
        Console.WriteLine("");
        Circulo CC = new Circulo();
        CC.CalcularArea();
        Console.WriteLine("");
        Triangulo T = new Triangulo();
        T.CalcularArea();
        Console.WriteLine("");

        Console.WriteLine("Empleados");
        Console.WriteLine("");
        Console.WriteLine("Empleado de tiempo completo");
        EmpleadoTiempoCompleto ETC = new EmpleadoTiempoCompleto("Juan", 500);
        ETC.CalcularSueldo();
        Console.WriteLine("");
        Console.WriteLine("Empleado de medio tiempo");
        EmpleadoMedioTiempo EMT = new EmpleadoMedioTiempo("Jose", 250);
        EMT.CalcularSueldo();
        Console.WriteLine("");

        Console.WriteLine("Vehiculos");
        Console.WriteLine("");
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Auto();
        vehiculos[1] = new Moto();
        vehiculos[2] = new Camion();
        foreach (Vehiculo i in vehiculos)
        {
            i.Arrancar();
            i.Acelerar();
        }
        Console.WriteLine("");

        Console.WriteLine("Museo");
        Console.WriteLine("");
        museo[] animales = new museo[4];
        animales[0] = new Perro();
        animales[1] = new Lobo();
        animales[2] = new Pato();
        animales[3] = new oveja();
        foreach (museo i in animales)
        {
            i.Sonido();
        }
        Console.WriteLine("");

        Console.WriteLine("Metodos interfaces");
        Console.WriteLine("");

        Console.WriteLine("Exportar informacion");
        Console.WriteLine("");
        Iexportable[] exportadores = new Iexportable[3];
        exportadores[0] = new ExportarExcel();
        exportadores[1] = new ExportarPDF();
        exportadores[2] = new ExportarCSV();
        string contenido = "Datos para exportar";
        foreach (Iexportable i in exportadores)
        {
            i.Exportar(contenido);
        }
        Console.WriteLine("");

        Console.WriteLine("Vehiculos");
        Console.WriteLine("");
        //IVehiculo IV = new IVehiculo();
        IAuto IA = new IAuto();
        IA.conducir();
        Console.WriteLine("");
        IMoto IM = new IMoto();
        IM.conducir();
        Console.WriteLine("");
        IBicicleta IB = new IBicicleta();
        IB.conducir();
        Console.WriteLine("");

        Console.WriteLine("API Rest");
        Console.WriteLine("");
        usuario U = new usuario();
        U.POST ("Nombre Jose, edad 23");
        U.GET(1);
        U.POST ("Edad 21");
        U.DELETE(1);
        Console.WriteLine("");

    }
}