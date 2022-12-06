using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUM
{
    internal class recursive
    {
    }
    public partial class frmBUM
    {
        private static void copiarCarpeta(string rutaCopia, string rutaDestino)
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
                if (!archivo.Contains("BUM"))   //filtro para carpeta BUM
                {
                    File.Copy(archivo, archivo.Replace(rutaCopia, rutaDestino), true);
                }
            }
        }
    }
 }
