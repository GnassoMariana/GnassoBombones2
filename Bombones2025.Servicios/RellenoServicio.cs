using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
    public class RellenoServicio
    {
        private readonly RellenoRepositorio _rellenoRepositorio = null!;

        public RellenoServicio(string ruta)
        {
            _rellenoRepositorio = new RellenoRepositorio(ruta);
        }

        public void Borrar(Relleno relleno)
        {
            _rellenoRepositorio.Borrar(relleno);
        }

        public bool Existe(Relleno relleno)
        {
            return _rellenoRepositorio.Existe(relleno);
        }

        public List<Relleno> GetRellenos()
        {
            return _rellenoRepositorio.GetRellenos();
        }

        public void Guardar(Relleno relleno)
        {
           if (relleno.RellenoId == 0)
           {
                _rellenoRepositorio.Guardar(relleno);
           }
           else
            {
                _rellenoRepositorio.Editar(relleno);
            }
            
        }
    }
}
