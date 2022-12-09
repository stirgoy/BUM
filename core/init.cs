using BUM.Properties;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BUM
{
    class init { }

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
            chkAskRestore.Text = strings.str_chk_ask_restore;
            btnImport.Text = strings.btn_import_cfg;
            btnExport.Text = strings.btn_export_cfg;
            /*
                Settings
            */


            //Fill list only if have data
            if (!(Settings.Default.listaJuegos == null) && !(Settings.Default.listaJuegos == "")) { actualizarLista(); }
            chkAskRestore.Checked = Settings.Default.chkAskRestore;

            
        }
    }
}
