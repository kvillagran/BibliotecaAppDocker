namespace BibliotecaAppDocker.Models
{
    public class Autor
    {
        public int AutorID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;

        // Relación: Un autor tiene varios libros
        public ICollection<Libro>? Libros { get; set; }
    }
}
