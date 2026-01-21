using System.Diagnostics;

namespace PracticaFinal;

public class ListaAutor : List<Autor>
{
    public ListaAutor()
    {
    }

    public void RellenarLista()
    {
        this.Add(new Autor("Autor1 Nombre Completo"));
        this.Add(new Autor("Autor2 Nombre Completo"));
        this.Add(new Autor("Autor3 Nombre Completo"));
        this.Add(new Autor("Autor4 Nombre Completo"));
    }

    public Autor Buscar(string nombreCompleto)
    {
        foreach (Autor autor in this)
        {
            if (autor.NombreCompleto.Equals(nombreCompleto))
                return autor;
        }

        return null;
    }

    public bool Insertar(Autor autor)
    {
        if (Buscar(autor.NombreCompleto) == null)
        {
            this.Add(autor);
            return true;
        }

        return false;
    }

    public void Mostrar()
    {
        foreach (Autor autor in this)
        {
            Debug.WriteLine(autor.ToString());
        }
    }
}
