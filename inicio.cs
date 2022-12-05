using BUM.Properties;
using System;
using System.Windows.Forms;

namespace BUM
{
    class inicio { }

    public partial class frmBUM
    {


        string BUM = "\\BUM";


        void init()
        {

            /*
            ListViewItem test = lstJuegos.Items.Add("uno");
            test.SubItems.Add("xD");
            
            Settings.Default.listaJuegos = "";
            Settings.Default.Save();
            
            string tes = Settings.Default.listaJuegos;
            MessageBox.Show(tes);
            
            string[,] test = crearArrayData();
            */

            if (!(Settings.Default.listaJuegos == null) && !(Settings.Default.listaJuegos == ""))
            {
                actualizarLista();               
                
            }
        }
    }
}
