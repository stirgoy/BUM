using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUM
    {
    class copiarCarpeta
    {
    }
    public partial class frmBUM
    {
        void copiarCarpeta(string rutaCopia, string rutaDestino, bool restaurar = false)
        {            
            foreach (string dir in Directory.GetDirectories(rutaCopia, "*", SearchOption.AllDirectories))
            {                 
                if (!dir.Contains("BUM"))   //filtro para carpeta BUM
                {
                    Directory.CreateDirectory(dir.Replace(rutaCopia, rutaDestino)); 
                }
            }
                        
            foreach (string archivo in Directory.GetFiles(rutaCopia, "*.*", SearchOption.AllDirectories))
            {
                bool pass = false;
                if (!archivo.Contains("BUM")) { pass = true; }   //filtro para carpeta BUM
                if (restaurar) { pass = true; }                  //bypass para restaurar

                if (pass) { File.Copy(archivo, archivo.Replace(rutaCopia, rutaDestino), true); }
            }
        }
    }
 }
