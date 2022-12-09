using System.Windows.Forms;

namespace BUM
{
    internal class actualizarLista{}

    public partial class frmBUM
    {

        void actualizarLista()
        {
            lstJuegos.Items.Clear();
            string[,] newList = crearArrayData();

            for (int i = 0; i < (newList.GetLength(0)); i++)
            {
                ListViewItem item = lstJuegos.Items.Add(newList[i, 0]);
                item.SubItems.Add(newList[i, 1]);
            }

        }
    }

}
