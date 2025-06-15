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
