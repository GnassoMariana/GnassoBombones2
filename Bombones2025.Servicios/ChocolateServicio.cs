using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class ChocolateServicio
    {
        private readonly ChocolateRepositorio _chocolateRepositorio = null!;

        public ChocolateServicio(string ruta)
        {
            _chocolateRepositorio = new ChocolateRepositorio(ruta);
        }

        public List<Chocolate> GetChocolates()
        {
            return _chocolateRepositorio.GetChocolates();
        }
    }
}
   

