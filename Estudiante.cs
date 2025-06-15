1. Definición de la Clase Estudiante
csharp
public class Estudiante
{
    // Propiedades
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string[] Telefonos { get; set; }

    // Constructor
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        
        // Validar que se proporcionen exactamente 3 teléfonos
        if (telefonos.Length != 3)
        {
            throw new ArgumentException("Debe proporcionar exactamente 3 números de teléfono.");
        }
        Telefonos = telefonos;
    }

    // Método para mostrar información del estudiante
    public override string ToString()
    {
        return $"ID: {Id}\n" +
               $"Nombre completo: {Nombres} {Apellidos}\n" +
               $"Dirección: {Direccion}\n" +
               $"Teléfonos: {Telefonos[0]}, {Telefonos[1]}, {Telefonos[2]}";
    }
}
2. Clase para Manejar un Array de Estudiantes
csharp
public class RegistroEstudiantes
{
    private Estudiante[] estudiantes;
    private int contador;

    // Constructor
    public RegistroEstudiantes(int capacidad)
    {
        estudiantes = new Estudiante[capacidad];
        contador = 0;
    }

    // Método para agregar un estudiante
    public void AgregarEstudiante(Estudiante estudiante)
    {
        if (contador < estudiantes.Length)
        {
            estudiantes[contador] = estudiante;
            contador++;
        }
        else
        {
            Console.WriteLine("El registro de estudiantes está lleno.");
        }
    }

    // Método para mostrar todos los estudiantes
    public void MostrarEstudiantes()
    {
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(estudiantes[i].ToString());
            Console.WriteLine("----------------------");
        }
    }

    // Método para buscar un estudiante por ID
    public Estudiante BuscarPorId(int id)
    {
        foreach (var estudiante in estudiantes)
        {
            if (estudiante?.Id == id)
            {
                return estudiante;
            }
        }
        return null;
    }
}
3. Ejemplo de Uso
csharp
class Program
{
    static void Main(string[] args)
    {
        // Crear registro con capacidad para 10 estudiantes
        RegistroEstudiantes registro = new RegistroEstudiantes(10);

        // Agregar estudiantes
        registro.AgregarEstudiante(new Estudiante(
            1, 
            "Juan Carlos", 
            "Pérez López", 
            "Calle 123, Ciudad", 
            new string[] { "555-1234", "555-5678", "555-9012" }
        ));

        registro.AgregarEstudiante(new Estudiante(
            2, 
            "María Alejandra", 
            "González Martínez", 
            "Avenida Principal 456", 
            new string[] { "555-3456", "555-7890", "555-2345" }
        ));

        // Mostrar todos los estudiantes
        Console.WriteLine("Listado completo de estudiantes:");
        registro.MostrarEstudiantes();

        // Buscar un estudiante por ID
        Console.WriteLine("\nBúsqueda de estudiante con ID 2:");
        Estudiante encontrado = registro.BuscarPorId(2);
        if (encontrado != null)
        {
            Console.WriteLine(encontrado.ToString());
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }
}
