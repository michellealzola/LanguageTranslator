using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            lblsTranslation.Text = "Buongiorno";
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblsTranslation.Text = "Buenos Dias";
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            lblsTranslation.Text = "Guten Morgen";
        }
    }
}
