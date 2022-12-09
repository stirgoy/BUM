using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BUM
{
    internal class actualizarListaSaves
    {
    }
    public partial class frmBUM
    {
        void actualizarListaSaves()
        {
            LstSaves.Items.Clear();
            ListViewItem item = lstJuegos.SelectedItems[0];
            string ruta = item.SubItems[1].Text;
            ruta += BUM;
            if (!(Directory.Exists(ruta)))
            {
                Directory.CreateDirectory(ruta);
            }

            string[] bups = Directory.GetDirectories(ruta);

            if (bups.Count() > 0)
            {
                foreach (string path in bups)
                {
                    string[] tmps = path.Split('\\');
                    LstSaves.Items.Add(tmps[tmps.Count() - 1]);
                }
            }

        }
    }
}
