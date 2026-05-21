using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private int clave;

    Dictionary <int, Alumno> mi_diccionario = new Dictionary <int, Alumno>();

    public void cargar_alumnos()
    {
        Alumno alum1 = new Alumno(10, "juan", 1000);
        Alumno alum2 = new Alumno(11, "Maria", 100);

        mi_diccionario.Add(alum1.Id,alum1);
        mi_diccionario.Add(alum2.Id, alum2);
    }

    public Dictionary<int, Alumno> obtenerdiccionario()
    {
        return mi_diccionario;
    }

    public Alumno buscar(int clave)
    {
        if (mi_diccionario.ContainsKey(clave))
        {
            return mi_diccionario[clave];
        }

        return null;
    }

    public void borrar(int clave)
    {
        if (mi_diccionario.ContainsKey(clave))
        {
            mi_diccionario.Remove(clave);
        }
    }
}
