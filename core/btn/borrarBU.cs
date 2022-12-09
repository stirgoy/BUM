using BUM.Properties;
using System.IO;
using System.Windows.Forms;

namespace BUM
{
    internal class borrarBU
    {
    }
    public partial class frmBUM
    {
        void borrarBU()
        {
            if (LstSaves.Items.Count > 0)
            {
                if (LstSaves.SelectedItem != null)
                {
                    ListViewItem item = lstJuegos.SelectedItems[0];
                    string ruta = item.SubItems[1].Text;
                    string BU = LstSaves.SelectedItem.ToString();

                    DialogResult = MessageBox.Show(
                        strings.str_ask_del_bu + BU + "?",
                        strings.str_atention,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (DialogResult == DialogResult.Yes)
                    {
                        Directory.Delete(ruta + BUM + "\\" + BU, true); ///<<<--- recursividad  ¬¬                        
                        actualizarListaSaves();
                    }
                }
            }

        }
    }
}
