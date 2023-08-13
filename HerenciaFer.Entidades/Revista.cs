using HerenciaFer.Entidades.Enums;

namespace HerenciaFer.Entidades
{


    public class Revista:Publicacion
    {
        private TipoRevista tipoRevista;

        public Revista(string nombre, DateTime fechaPublicacion, 
            int cantidadPaginas, decimal precio, TipoRevista tipoRevista) : base(nombre, fechaPublicacion, cantidadPaginas, precio)
        {
            this.tipoRevista = tipoRevista;
        }

        public TipoRevista TipoRevista { get => tipoRevista; set => tipoRevista = value; }

        public new string MostrarDatos()
        {
            return base.MostrarDatos() + Environment.NewLine + $"Tipo Revista:{this.tipoRevista}";
        }
    }
}
