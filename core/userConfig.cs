using BUM.Properties;
using System.Windows.Forms;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BUM
{
    internal class userConfig
    {
    }

    [Serializable]
    class currSet
    {
        public string arrSett { get; set; }
        public bool chkR { get; set; } 
    }


    public partial class frmBUM
    {
        void saveUserConfig()
        {
            
            
            SFD.ShowDialog();
            
            currSet fts = new currSet();
            fts.arrSett = Settings.Default.listaJuegos;
            fts.chkR = Settings.Default.chkAskRestore;

            

            BinaryFormatter formatter= new BinaryFormatter();

            using (FileStream stream = new FileStream(SFD.FileName, FileMode.Create))
            {
                formatter.Serialize(stream,fts);
            }

        }

        void loadUserConfig()
        {
            OFD.ShowDialog();
            


            BinaryFormatter formatter = new BinaryFormatter();
            currSet dsConf;
            using (FileStream stream = new FileStream(OFD.FileName, FileMode.Open))
            {
                dsConf = (currSet)formatter.Deserialize(stream);
                
            }

            Settings.Default.listaJuegos = dsConf.arrSett;
            Settings.Default.chkAskRestore = dsConf.chkR;


        }

    }
}