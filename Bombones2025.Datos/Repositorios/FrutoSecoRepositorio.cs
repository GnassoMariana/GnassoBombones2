using Bombones2025.Entidades;

namespace Bombones2025.Datos.Repositorios
{
    public class FrutoSecoRepositorio
    {
        //Atributo privado del repo donde se almacenan los frutos
        private List<FrutoSeco> frutosSecos = new();
        private readonly string ruta = null!;
        public FrutoSecoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        /// <summary>
        /// Método para enviar la lista de países a otra capa
        /// </summary>
        /// <returns></returns>
        public List<FrutoSeco> GetFrutos()
        {
            return frutosSecos.OrderBy(f=>f.Descripcion).ToList();
        }
        /// <summary>
        /// Método para leer los países desde el archivo secuencial
        /// </summary>
        /// <param name="ruta">Se pasa el nombre del archivo</param>
        private void LeerDatos()
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);
            foreach (var registro in registros)
            {
                if(string.IsNullOrWhiteSpace(registro))
                {
                    continue;
                }
                try
                {
                    FrutoSeco fruto = ConstruirFruto(registro);
                    frutosSecos.Add(fruto);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al leer el registro {registro}", ex);
                }
            }

        }
        /// <summary>
        /// Método privado para obtener un fruto seco
        /// </summary>
        /// <param name="registro">Recibe un string con los datos del país separados por |</param>
        /// <returns>Un pais</returns>
        private FrutoSeco ConstruirFruto(string registro)
        {
            var campos = registro.Split('|');
            var frutoSecoId = int.Parse(campos[0].Trim());
            var descripcion = campos[1].Trim();
            return new FrutoSeco()
            {
                Descripcion = descripcion,
                FrutoSecoId = frutoSecoId
            };
        }
        /// <summary>
        /// Para buscar el ultimo lugar en la lista y se le suma uno.
        /// Simulla un autoincremento del id
        /// </summary>
        /// <returns></returns>
        private int SetearFrutoId()
        {
            return frutosSecos.Max(f => f.FrutoSecoId) + 1;
        }

        public bool Existe(FrutoSeco fruto)
        {
            return fruto.FrutoSecoId==0? frutosSecos.Any(f=>f.Descripcion == fruto.Descripcion):
                frutosSecos.Any(f => f.Descripcion == fruto.Descripcion && f.FrutoSecoId != fruto.FrutoSecoId);
        }

        /// <summary>
        /// Agrega el fruto al archivo txt
        /// </summary>
        /// <param name="fruto"></param>
        public void Guardar(FrutoSeco fruto)
        {
            fruto.FrutoSecoId = SetearFrutoId();
            frutosSecos.Add(fruto);
            if(File.Exists(ruta))
            {
                var registros = File.ReadAllText(ruta);
                if(!string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
                {
                    File.WriteAllText(ruta, Environment.NewLine);
                }
            }
            using(var escritor = new StreamWriter(ruta,true))
            {
                string linea = ConstruirLinea(fruto);
                escritor.WriteLine(linea);
            }

        }

        private string ConstruirLinea(FrutoSeco fruto)
        {
            return $"{fruto.FrutoSecoId}| {fruto.Descripcion}";
        }

        public void Borrar(FrutoSeco frutoParaBorrar)
        {
            var fruto = frutosSecos.FirstOrDefault(f=> f.Descripcion == frutoParaBorrar.Descripcion);

            if(fruto is null)
            {
                return;
            }
            frutosSecos.Remove(fruto);
            //Select es un metodo de linq ---BUSCAR!!!---
            var registros = frutosSecos.Select(f => ConstruirLinea(f)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public void Editar(FrutoSeco fruto)
        {
            var  frutoEditado = frutosSecos.FirstOrDefault(f => f.FrutoSecoId == fruto.FrutoSecoId);
            if (frutoEditado is null)
            {
                return;
            }
            frutoEditado.Descripcion = fruto.Descripcion;
            var registros = frutosSecos.Select(f => ConstruirLinea(f)).ToArray();
            File.WriteAllLines(ruta, registros);

        }
    }
}
