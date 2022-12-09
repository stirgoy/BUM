using BUM.Properties;
using System.IO;
using System.Windows.Forms;

namespace BUM
{
    internal class anadirSave
    {
    }

    public partial class frmBUM
    {
        void anadirSave()
        {
            if (txtSave.Text != "" && txtSave.Text != null)
            {
                if (lstJuegos.SelectedItems.Count > 0)
                {

                    ListViewItem item = lstJuegos.SelectedItems[0];
                    string ruta = item.SubItems[1].Text;
                    string rutaBU = ruta + BUM + "\\" + txtSave.Text;
                    string[] files = Directory.GetFiles(ruta);
                    Directory.CreateDirectory(rutaBU);

                    copiarCarpeta(ruta, rutaBU);

                    actualizarListaSaves();

                    txtSave.Text = "";

                }
                else
                {
                    MessageBox.Show(
                        strings.str_melon,
                        strings.str_error,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    strings.str_err_blank_save,
                    strings.str_error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
