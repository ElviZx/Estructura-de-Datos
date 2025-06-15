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
