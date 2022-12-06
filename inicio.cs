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
                LOCALIZATION
            */

            lstJuegos.Columns[0].Text = strings.str_col_juegos;
            lstJuegos.Columns[1].Text = strings.str_col_path_saves;
            btnAnadirJuego.Text = strings.str_add;
            btnAnadirSave.Text = strings.str_add;
            btnBorrarJuego.Text = strings.str_delete;
            btnBorrarSave.Text = strings.str_delete;
            btnRestaurar.Text = strings.str_restore;
            btnAbrirUbicacion.Text = strings.str_open_folder;

            //Load user data
            if (!(Settings.Default.listaJuegos == null) && !(Settings.Default.listaJuegos == ""))
            {
                actualizarLista();               
                
            }
        }
    }
}
