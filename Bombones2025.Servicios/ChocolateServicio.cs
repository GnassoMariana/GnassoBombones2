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

        public void Borrar(Chocolate chocoBorrar)
        {
             _chocolateRepositorio.Borrar(chocoBorrar);
        }

        public bool Existe(Chocolate choco)
        {
            return _chocolateRepositorio.Existe(choco);
        }

        public List<Chocolate> GetChocolates()
        {
            return _chocolateRepositorio.GetChocolates();
        }

        public void Guardar(Chocolate choco)
        {
            if (choco.ChocolateId== 0)
            {
                _chocolateRepositorio.Guardar(choco);

            }
            else
            {
                _chocolateRepositorio.Editar(choco);
            }
        }
    }
}


