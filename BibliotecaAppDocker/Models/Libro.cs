namespace BibliotecaAppDocker.Models
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; }

        // Relación: Un libro pertenece a un autor
        public int AutorID { get; set; }
        public Autor? Autor { get; set; }

        // Relación: Un libro pertenece a una categoría
        public int CategoriaID { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
