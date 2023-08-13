using HerenciaFer.Entidades;
using System.Text;

namespace HerenciaFer.Datos
{
    public class PuestoDeDiarios
    {
        private List<Publicacion> listaPublicaciones;
        public PuestoDeDiarios()
        {
            listaPublicaciones = new List<Publicacion>();
        }

        public void Agregar(Publicacion publicacionAgregada)
        {
            listaPublicaciones.Add(publicacionAgregada);
        }
        public List<Publicacion> GetListaPublicaciones()
        {
            return listaPublicaciones;
        }

        public int GetCantidad()
        {
            return listaPublicaciones.Count;
        }
        public string MostrarDatosPublicaciones()
        {
            StringBuilder sb=new StringBuilder();
            foreach (var item in listaPublicaciones)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();   
        }
    }
}