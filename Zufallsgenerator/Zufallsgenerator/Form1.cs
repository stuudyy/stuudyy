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
    public partial class Form1 : Form
    {
        internal static Form1 f1;

        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        internal ListViewItem lvItem;
        


        private void btnHinzufügen_Click(object sender, EventArgs e)
        {

        }
    }
}
