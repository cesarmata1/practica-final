namespace PracticaFinal;

public enum TipoPublicacion { LibroCompleto, CapituloDeLibro, ArticuloRevista, Congreso }
public enum EstadoPublicacion { EnRevision, Aceptado, Rechazado }

public class Publicacion {
    public string Identificador { get; set; }
    public string Titulo { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public TipoPublicacion Tipo { get; set; }
    public EstadoPublicacion Estado { get; set; }
    public List<Autor> Autores { get; set; } // Puede tener uno o varios autores

    public Publicacion(string identificador, string titulo, DateTime fechaPublicacion, 
        TipoPublicacion tipo, EstadoPublicacion estado, List<Autor> autores)
    {
        Identificador = identificador;
        Titulo = titulo;
        FechaPublicacion = fechaPublicacion;
        Tipo = tipo;
        Estado = estado;
        Autores = autores;
    }

    public Publicacion()
    {
        Autores = new List<Autor>();
    }

    public override string ToString()
    {
        return Identificador + " - " + Titulo + " - " + FechaPublicacion.ToShortDateString() + 
               " - " + Tipo + " - " + Estado;
    }
}