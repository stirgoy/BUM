using BUM.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUM
{
    internal class userData{}

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

        string[,] crearArrayData()
        {
            string data = Settings.Default.listaJuegos;
            string[] primerParse = data.Split(';');            
            string[,] ret = new string[primerParse.Length,2];

            for (int i = 0; i < primerParse.Count(); i++)
            {
                string[] tmpI = primerParse[i].Split(',');
                ret[i, 0] = tmpI[0];
                ret[i, 1] = tmpI[1];
            }        

            return ret;
        }

        void borrarJuego()
        {
            ListViewItem item = lstJuegos.SelectedItems[0];
            string[] borrar = { item.Text, item.SubItems[0].Text };

            lstJuegos.Items.Remove(lstJuegos.SelectedItems[0]);

            string newS = "";
            string[,] old = crearArrayData();
            
            for (int i = 0; i < (old.GetLength(0) ); i++)
            {
                if (old[i,0] != borrar[0] && old[i,1] != borrar[1])
                {
                    
                    if (newS != "") { newS += ";"; }
                    newS += old[i, 0] + "," + old[i,1];

                }
            }

            Settings.Default.listaJuegos = newS;
            Settings.Default.Save();
        }


        void anadirJuego(string juego, string rutaSave)
        {
            if (!(txtNombreJuego.Text == ""))
            {
                string DATA = Settings.Default.listaJuegos;
                if (!(DATA == "")) { DATA += ";"; }
                DATA += juego + "," + rutaSave;
                Settings.Default.listaJuegos = DATA;
                Settings.Default.Save();
                actualizarLista();
            }
            else
            {
                MessageBox.Show("El nombre del jueo no puede estar en blanco", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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


        void borrarBU()
        {
            if (LstSaves.Items.Count > 0)
            {
                if (LstSaves.SelectedItem != null)
                {
                    ListViewItem item = lstJuegos.SelectedItems[0];
                    string ruta = item.SubItems[1].Text;
                    string BU = LstSaves.SelectedItem.ToString();

                    DialogResult = MessageBox.Show("¿Seguro que quieres borrar el backup " + BU + "?",
                        "Atencion",
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


        void anadirSave()
        {
            if (txtSave.Text != "" && txtSave.Text != null)
            {
                if(lstJuegos.SelectedItems.Count > 0)
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
                    MessageBox.Show("¡Selecciona un juego priero MELON!", 
                        "Error",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre del backup no puede estar en blanco", 
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }


        void restaurarSave()
        {
            if ((lstJuegos.Items.Count > 0) && (LstSaves.Items.Count > 0))
            {
                if (LstSaves.SelectedItem.ToString() != "")
                {
                    DialogResult msg = MessageBox.Show("¿Estas seguro de que quieres estaurar este backup?, se perdera el save actual.",
                        "Atencion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if(msg == DialogResult.Yes)
                    {
                        ListViewItem item = lstJuegos.SelectedItems[0];
                        string ruta = item.SubItems[1].Text;
                        string BU = LstSaves.SelectedItem.ToString();
                        string rutaBU = ruta + BUM + "\\" + BU;

                        string[] files = Directory.GetFiles(ruta);                                                
                        foreach (string file in files)
                        {
                            File.Delete(file);
                        }

                        files = null;
                        files = Directory.GetFiles(rutaBU);
                        foreach (string file in files)
                        {
                            string fname = Path.GetFileName(file);
                            File.Copy(file, ruta + "\\" + fname);
                        }

                        
                    }

                }
            }
        }


    }

}
