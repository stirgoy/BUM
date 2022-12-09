using BUM.Properties;
using System.Windows.Forms;

namespace BUM
{
    internal class borrarJuego
    {
    }
    public partial class frmBUM
    {
        void borrarJuego()
        {
            ListViewItem item = lstJuegos.SelectedItems[0];
            string[] borrar = { item.Text, item.SubItems[0].Text };

            lstJuegos.Items.Remove(lstJuegos.SelectedItems[0]);

            string newS = "";
            string[,] old = crearArrayData();

            for (int i = 0; i < (old.GetLength(0)); i++)
            {
                if (old[i, 0] != borrar[0] && old[i, 1] != borrar[1])
                {

                    if (newS != "") { newS += ";"; }
                    newS += old[i, 0] + "," + old[i, 1];

                }
            }

            Settings.Default.listaJuegos = encrypt(newS);
            Settings.Default.Save();
        }
    }
}
