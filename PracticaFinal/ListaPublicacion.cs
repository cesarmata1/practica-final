using System.Diagnostics;

namespace PracticaFinal;

public class ListaPublicacion : List<Publicacion>
{
    public ListaPublicacion()
    {
    }

    public void RellenarLista()
    {
        this.Add(new Publicacion(
            "P001",
            "Publicación 1",
            DateTime.Now.AddMonths(-3),
            TipoPublicacion.LibroCompleto,
            EstadoPublicacion.EnRevision,
            new List<Autor> { new Autor("Autor1 Nombre Completo") }
        ));
        this.Add(new Publicacion(
            "P002",
            "Publicación 2",
            DateTime.Now.AddMonths(-1),
            TipoPublicacion.ArticuloRevista,
            EstadoPublicacion.Aceptado,
            new List<Autor> { new Autor("Autor2 Nombre Completo"), new Autor("Autor3 Nombre Completo") }
        ));
    }

    public Publicacion Buscar(string identificador)
    {
        foreach (Publicacion publicacion in this)
        {
            if (publicacion.Identificador.Equals(identificador))
                return publicacion;
        }

        return null;
    }

    public bool Insertar(Publicacion publicacion)
    {
        if (Buscar(publicacion.Identificador) == null)
        {
            this.Add(publicacion);
            return true;
        }

        return false;
    }

    public void Mostrar()
    {
        foreach (Publicacion publicacion in this)
        {
            Debug.WriteLine(publicacion.ToString());
        }
    }

    public ListaPublicacion SeleccionarPorTipo(TipoPublicacion tipo)
    {
        ListaPublicacion listaAux = new ListaPublicacion();
        foreach (Publicacion publicacion in this)
        {
            if (publicacion.Tipo == tipo)
                listaAux.Add(publicacion);
        }

        return listaAux;
    }
}
