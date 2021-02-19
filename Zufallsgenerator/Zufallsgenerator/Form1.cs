using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Zufallsgenerator
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;

        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        internal ListViewItem lvItem;
        internal List<Projekte> projektliste;
        private XmlSerializer serializer;

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {

        }

        internal void idSetzen()
        {
            int temp = 0;
            foreach (Projekte c in projektliste)
            {
                if (c.Nummer > temp)
                {
                    temp = c.Nummer;

                }
                Projekte.Autonum = temp + 1;
            }

        }
        internal void listViewEinlesen()
        {
            listView1.Items.Clear();
            foreach (Projekte p in projektliste)
            {
                lvItem = new ListViewItem("");
                lvItem.SubItems.Add(p.Nummer.ToString());
                lvItem.SubItems.Add(p.Projekt);
                listView1.Items.Add(lvItem);


            }


        }
        internal void xmlSerilasieren()
        {
            try
            {
                FileStream fs = new FileStream("projektliste.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(fs, projektliste);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisieren: " + ex.Message);
            }



        }
        internal void xmlDeserilasieren()
        {
            try
            {
                FileStream fs = new FileStream("projektliste.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                projektliste = (List<Projekte>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisieren: " + ex.Message);
            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //xmlSerilasieren();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;


            projektliste = new List<Projekte>();
            //serializer = new XmlSerializer(typeof(List<Projekte>));

            projektliste.Add(new Projekte("OpenHakDay"));
            
            //xmlDeserilasieren();
            listViewEinlesen();
            idSetzen();
        }
    }
}
