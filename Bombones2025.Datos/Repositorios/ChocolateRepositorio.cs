using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class ChocolateRepositorio
    {
        private List<Chocolate> chocolates = new();
        private readonly string ruta = null!;

        public ChocolateRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        public List<Chocolate> GetChocolates()
        {
            return chocolates;
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
                Chocolate choco = ConstruirChocolate(registro);
                chocolates.Add(choco);
            }
        }

        private Chocolate ConstruirChocolate(string registro)
        {
            var campos = registro.Split('|');
            var chocolateId = int.Parse(campos[0]);
            var descripcion = campos[1];
            return new Chocolate()
            {
                Descripcion = descripcion,
                ChocolateId = chocolateId
            };
        }
    }
}

