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
            return chocolates.OrderBy(c=> c.Descripcion).ToList();
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
        private int SetearChocolateId()
        {
            return chocolates.Max(c => c.ChocolateId) + 1;
        }

        public bool Existe(Chocolate chocolate)
        {
            if (chocolate.ChocolateId == 0)
            {
                return chocolates.Any(c => c.Descripcion == chocolate.Descripcion);
            }
            else
            {
                return chocolates.Any(c => c.Descripcion == chocolate.Descripcion && c.ChocolateId != chocolate.ChocolateId);

            }
        }

        public void Guardar(Chocolate choco)
        {
            choco.ChocolateId = SetearChocolateId();
            chocolates.Add(choco);
            //if(File.Exists(ruta))
            //{
            //    var registros = File.ReadAllLines(ruta);
            //    if(string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
            //    {
            //        File.WriteAllText(ruta, Environment.NewLine);
            //    }
                
            //}
            using (var escritor= new StreamWriter(ruta, true))
            {
                string linea = ConstruirLinea(choco);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(Chocolate choco)
        {
           return $"{choco.ChocolateId}|{choco.Descripcion}";
        }

        public void Borrar(Chocolate chocoBorrar)
        {
            var choco = chocolates.FirstOrDefault(c => c.Descripcion == chocoBorrar.Descripcion);
            if (choco is null) return;

            chocolates.Remove(choco);

            var registros = chocolates.Select(c => ConstruirLinea(c)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public void Editar(Chocolate choco)
        {
            var chocoEditado= chocolates.FirstOrDefault(c => c.ChocolateId == choco.ChocolateId);
            if(chocoEditado is null) return;
            chocoEditado.Descripcion = choco.Descripcion;
            var registros = chocolates.Select(c => ConstruirLinea(c)).ToArray();
            File.WriteAllLines(ruta, registros);

        }
    }
}

