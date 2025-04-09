using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class RellenoRepositorio
    {
        private List<Relleno> rellenos = new();
        private readonly string ruta = null!;

        public RellenoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        public List<Relleno> GetRellenos()
        {
            return rellenos;
        }

        private void LeerDatos()
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);
            foreach (var registro in registros)
            {
                Relleno relleno = ConstruirRelleno(registro);
                rellenos.Add(relleno);
            }
        }

        private Relleno ConstruirRelleno(string registro)
        {
            var campos = registro.Split('|');
            var rellenoId = int.Parse(campos[0]);
            var descripcion = campos[1];
            return new Relleno()
            {
                Descripcion = descripcion,
                RellenoId = rellenoId
            };
        }
    }
    
}
