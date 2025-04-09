using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class FrutoSecoServicio
    {
        private readonly FrutoSecoRepositorio _frutoRepositorio = null!;
        public FrutoSecoServicio(string ruta)
        {
            _frutoRepositorio = new FrutoSecoRepositorio(ruta);
        }

        public void Borrar(FrutoSeco frutoParaBorrar)
        {
           _frutoRepositorio.Borrar(frutoParaBorrar);
        }

        public bool Existe(FrutoSeco fruto)
        {
            return  _frutoRepositorio.Existe(fruto);
        }

        public List<FrutoSeco> GetFrutos()
        {
            return _frutoRepositorio.GetFrutos();
        }

        public void Guardar(FrutoSeco fruto)
        {
            if (fruto.FrutoSecoId == 0)
            {
                _frutoRepositorio.Guardar(fruto);

            }
            else
            {
                _frutoRepositorio.Editar(fruto);
            }
        }
        //public List<FrutoSeco> GetLista()
        //{
        //    return _frutoRepositorio.GetLista();
        //}
    }
}
