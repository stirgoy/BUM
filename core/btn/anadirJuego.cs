using BUM.Properties;
using System.Windows.Forms;

namespace BUM
{
    internal class anadirJuego
    {
    }
    public partial class frmBUM
    {
        void anadirJuego(string juego, string rutaSave)
        {
            if (!(txtNombreJuego.Text == ""))
            {
                string DATA = decrypt(Settings.Default.listaJuegos);
                if (!(DATA == "")) { DATA += ";"; }
                DATA += juego + "," + rutaSave;
                Settings.Default.listaJuegos = encrypt(DATA);
                Settings.Default.Save();
                actualizarLista();
            }
            else
            {
                MessageBox.Show(
                    strings.str_err_blank_game,
                    strings.str_error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
