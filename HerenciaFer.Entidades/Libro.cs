namespace HerenciaFer.Entidades
{
    public class Libro:Publicacion
    {
        private int isbn;
        private string autor;
        private string categoria;
        private string editorial;

        public Libro(string nombre, DateTime fechaPublicacion, 
            int cantidadPaginas, decimal precio,
            int isbn, string autor
            ) : base(nombre, fechaPublicacion, cantidadPaginas, precio)
        {
            this.isbn = isbn;
            this.autor = autor;
        }
    }
}
