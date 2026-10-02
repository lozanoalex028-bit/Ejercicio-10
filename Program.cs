Console.WriteLine("Temperatura de motor");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el nombre del motor: ");
motor1.Nombre = Console.ReadLine() ?? "Sin nombre";

Console.Write("Ingrese la temperatura del motor: ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor: ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Nombre}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Velocidad: {motor1.Velocidad} RPM");
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");

// Definición de la clase
class Motor
{
    // Propiedades
    public string Nombre { get; set; } = "";

    public double Temperatura { get; set; }

    public double Velocidad { get; set; }

    // Método para determinar el estado
    public string ObtenerEstado()
    {
        if (Temperatura <= 70)
        {
            return "Temperatura normal";
        }
        else
        {
            return "Temperatura Alta";
        }
    }
}