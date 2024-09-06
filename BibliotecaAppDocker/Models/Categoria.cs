namespace BibliotecaAppDocker.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Relación: Una categoría contiene varios libros
        public ICollection<Libro>? Libros { get; set; }
    }
}
