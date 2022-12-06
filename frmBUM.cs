using BUM.Properties;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Diagnostics;


/*
 
 UPDATES:
    exportar/importar configuracion de BUM
    Imagenes
    Informacion de saves
        fecha, hora
    Exportar todos los saves
    check para obviar preguntar al restaurar
 
 
 */

namespace BUM
{
    public partial class frmBUM : Form
    {
        public frmBUM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            init();
        }

        private void btnAnadirJuego_Click(object sender, EventArgs e)
        {
            if(txtNombreJuego.Text != "")
            { 
                FBD.ShowDialog();
                string ruta = FBD.SelectedPath;
                anadirJuego(txtNombreJuego.Text,ruta);
                txtNombreJuego.Text = "";
            } 
            else
            {
                MessageBox.Show(
                    strings.str_err_blank_game, 
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnBorrarJuego_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show(
                strings.str_ask_del_game,
                strings.str_atention,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                if (lstJuegos.SelectedItems[0] != null)
                {                    
                    borrarJuego();                    
                }
            }
            
        }

        private void lstJuegos_MouseClick(object sender, MouseEventArgs e)
        {
            actualizarListaSaves();
        }

        private void btnBorrarSave_Click(object sender, EventArgs e)
        {
            borrarBU();
        }

        private void btnAnadirSave_Click(object sender, EventArgs e)
        {
            anadirSave();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            restaurarSave();
        }

        private void btnAbrirUbicacion_Click(object sender, EventArgs e)
        {

            ListViewItem item = lstJuegos.SelectedItems[0];
            string ruta = item.SubItems[1].Text;
            Process.Start("explorer", ruta);
        }
    }
}
