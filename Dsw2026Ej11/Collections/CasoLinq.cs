using Dsw2026Ej11.Domain;
using System.Linq;
namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public Libro GetPrimero()
    {
        List<Libro> listaDeLibros = Libro.CrearLista(); 
        return listaDeLibros.First();
    }
    public Libro GetUltimo()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.Last();
    }
    public decimal GetTotalPrecios()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.Sum(libro => libro.Precio);
    }
    public decimal GetPromedioPrecios()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.Average(libro => libro.Precio) ;
    }
    public List<Libro> GetListById()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.Where(libro => libro.Id > 15).ToList();
    }
    public List<string> GetLibros()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }
    public Libro GetMayorPrecio()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.OrderByDescending(libro => libro.Precio).First();
    }
    public Libro GetMenorPrecio()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.OrderBy(libro => libro.Precio).First();
    }
    public List<Libro> GetMayorPromedio()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        decimal promedio = listaDeLibros.Average(libro => libro.Precio);
        return listaDeLibros.Where(libro => libro.Precio > promedio).ToList();
    }
    public List<Libro> GetOrdenadosPorTituloDescendente()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        return listaDeLibros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}