using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zufallsgenerator
{
    public partial class Form2 : Form
    {
        internal static Form2 f2;
        public Form2()
        {
            f2 = this;
            InitializeComponent();
        }
        internal int indexx;
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            f2.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtEingabe.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen sie das Feld aus!");
                return;
            }
            if (this.Text.Equals("Hinzufügen"))
            {
                Form1.f1.projektliste.Add(new Projekte(txtEingabe.Text));
            }
            else
            {
                Form1.f1.projektliste[indexx].Projekt = txtEingabe.Text;
               
            }
            Form1.f1.xmlSerilasieren();
            Form1.f1.projektliste = Form1.f1.projektliste.OrderBy(o => o.Nummer).ToList();
            Form1.f1.listViewEinlesen();
            this.Close();
        }
    }
}
