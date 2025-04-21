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
            return rellenos.OrderBy(r=>r.Descripcion).ToList();
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

        public bool Existe(Relleno relleno)
        {
            return relleno.RellenoId ==0? rellenos.Any(r => r.Descripcion == relleno.Descripcion) :
                rellenos.Any(r => r.Descripcion == relleno.Descripcion && r.RellenoId != relleno.RellenoId);
        }

        public void Guardar(Relleno relleno)
        {
            relleno.RellenoId = SetearRellenoId();
            rellenos.Add(relleno);
            if(File.Exists(ruta))
            {
                var registros = File.ReadAllText(ruta);
                if(!string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
                {
                   File.WriteAllText(ruta, Environment.NewLine);
                }
            }
            using(var escritor = new StreamWriter(ruta, true))
            {
                string linea = ConstruirLinea(relleno);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(Relleno relleno)
        {
            return $"{relleno.RellenoId}|{relleno.Descripcion}";
        }

        private int SetearRellenoId()
        {
            return rellenos.Max(r => r.RellenoId) + 1;
        }

        public void Editar(Relleno relleno)
        {
            var rellenoEditado = rellenos.FirstOrDefault(r => r.RellenoId == relleno.RellenoId);
            if(rellenoEditado is null)
            {
                return;
            }
            rellenoEditado.Descripcion = relleno.Descripcion;
            var registros = rellenos.Select(r => ConstruirLinea(r)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public void Borrar(Relleno relleno)
        {
            Relleno rellenoBorrar= rellenos.FirstOrDefault(r=> r.Descripcion == relleno.Descripcion)!;
            if (rellenoBorrar is null)
            {
                return;
            }
            rellenos.Remove(rellenoBorrar);
            var registros = rellenos.Select(r => ConstruirLinea(r)).ToArray();
            File.WriteAllLines(ruta, registros);
        }
    }
    
}
