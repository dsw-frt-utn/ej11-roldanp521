using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Tests;
internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    
    public static void EjemploList()
    {
        List<Alumno> alumnos = new List<Alumno>();
        Alumno alum1 = new Alumno(10, "Pedro", 1000);
        Alumno alum2 = new Alumno(11, "Raul", 100);
        Alumno alum3 = new Alumno(11, "Lucrecia", 100);
        alumnos.Add(alum1);
        alumnos.Add(alum2);
        alumnos.Add(alum3);

        Console.WriteLine("--- Lista Original ---");
        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine("\n--- Buscando alumno existente (Pedro) ---");
        Alumno alumnoQueExiste = alumnos.Find(a => a.Nombre == "Pedro");

        if (alumnoQueExiste != null)
        {
            Console.WriteLine(alumnoQueExiste.ToString());
        }

        Console.WriteLine("\n--- Buscando alumno inexistente (Juan) ---");
        Alumno alumnoQueNoExiste = alumnos.Find(a => a.Nombre == "Juan");

        if (alumnoQueNoExiste == null)
        {
            Console.WriteLine("No existe");
        }

        alumnos.Remove(alum3);
        alumnos.RemoveAt(0);

        Console.WriteLine("--- Lista con eliminado Pedro y  Lucrecia ---");
        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

        Dictionary<int, Alumno> mi_diccionario = new Dictionary<int, Alumno>();
        int clave;
        Alumno alum1 = new Alumno(10, "Roberto", 1000);
        Alumno alum2 = new Alumno(11, "Guillermo", 100);
        Alumno alum3 = new Alumno(13, "Nestor", 100);
        mi_diccionario.Add(alum1.Id, alum1);
        mi_diccionario.Add(alum2.Id, alum2);
        mi_diccionario.Add(alum3.Id, alum3);

        foreach (var alumno in mi_diccionario)
        {
            Console.WriteLine(alumno.Value.ToString());
        }

        Console.WriteLine("\n--- Buscando alumno existente (Roberto) ---");

        if (mi_diccionario.ContainsKey(10))
        {
            Console.WriteLine(mi_diccionario[10].ToString());
        }

        Console.WriteLine("\n---Buscando alumno no existente---");

        if (!mi_diccionario.ContainsKey(20))
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Lista después de eliminar la clave 11 (Raul) ---");

        if (mi_diccionario.ContainsKey(11))
        {
            mi_diccionario.Remove(11);
        }

        foreach (var alumno in mi_diccionario)
        {
            Console.WriteLine(alumno.Value.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq consultas = new CasoLinq();
        Console.WriteLine("\n---Obtener el primer libro--");
        Console.WriteLine(consultas.GetPrimero());
        Console.WriteLine("\n---Obtener el ultimo libro--");
        Console.WriteLine(consultas.GetUltimo());
        Console.WriteLine("\n---Obtener la suma de precios--");
        Console.WriteLine(consultas.GetTotalPrecios());
        Console.WriteLine("\n---Obtener el promedio de precios--");
        Console.WriteLine(consultas.GetPromedioPrecios());
        Console.WriteLine("\n---Obtener la lista de libros con Id mayor a 15--");
        foreach (var libro in consultas.GetListById())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("\n---Obtener una lista de cada libro con su título y precio en formato moneda--");
        foreach (var libro in consultas.GetLibros())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("\n---Obtener el libro con el precio más alto--");
        Console.WriteLine(consultas.GetMayorPrecio());
        Console.WriteLine("\n---Obtener el libro con el precio más bajo--");
        Console.WriteLine(consultas.GetMenorPrecio());
        Console.WriteLine("\n--- Obtener los libros cuyo precio sea mayor al promedio--");
        foreach (var libro in consultas.GetMayorPromedio())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine("\n---Obtener los libros ordenados por título de forma descendente--");
        foreach (var libro in consultas.GetOrdenadosPorTituloDescendente())
        {
            Console.WriteLine(libro.ToString());
        }
    }
}