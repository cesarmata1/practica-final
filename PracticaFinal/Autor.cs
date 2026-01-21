namespace PracticaFinal;

public class Autor {
    public string NombreCompleto { get; set; }

    public Autor(string nombreCompleto)
    {
        NombreCompleto = nombreCompleto;
    }

    public Autor() {}

    public override string ToString()
    {
        return NombreCompleto;
    }
}