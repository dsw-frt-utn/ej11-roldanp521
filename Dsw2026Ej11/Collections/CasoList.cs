using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList 
{
    List <Alumno> alumnos = new List<Alumno> ();

    public void cargar_alumnos()
    {
        Alumno alum1 = new Alumno(10, "juan", 1000);
        Alumno alum2 = new Alumno(11, "Maria", 100);
        alumnos.Add(alum1);
        alumnos.Add (alum2);
    }

    public List<Alumno> obtenerlista()
    {
        return alumnos;
    }

    public Alumno buscar (string nombre_buscado)
    {
        foreach (var alumno in alumnos)
        {
            if (nombre_buscado == alumno.Nombre )
            {
                return alumno;
            }
        }
        return null;
    }

    public void eliminar(Alumno alum1)
    {
        alumnos.Remove(alum1);
    }

    public void eliminar_en_posicion(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }
}
