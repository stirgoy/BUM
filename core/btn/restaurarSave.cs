using System.Windows.Forms;

namespace BUM
{
    internal class restaurarSave
    {
    }

    public partial class frmBUM
    {
        void restaurarSave()
        {
            ListViewItem item = lstJuegos.SelectedItems[0];
            string ruta = item.SubItems[1].Text;
            string rutaBU = ruta + BUM + "\\" + LstSaves.SelectedItem.ToString();

            copiarCarpeta(rutaBU, ruta, true);

        }
    }
}
