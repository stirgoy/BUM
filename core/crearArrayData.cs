using BUM.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUM
{
    internal class crearArrayData
    {
    }
    public partial class frmBUM
    {
        string[,] crearArrayData()
        {
            string data = Settings.Default.listaJuegos;
            string[] primerParse = data.Split(';');
            string[,] ret = new string[primerParse.Length, 2];

            for (int i = 0; i < primerParse.Count(); i++)
            {
                string[] tmpI = primerParse[i].Split(',');
                ret[i, 0] = tmpI[0];
                ret[i, 1] = tmpI[1];
            }

            return ret;
        }
    }
}
