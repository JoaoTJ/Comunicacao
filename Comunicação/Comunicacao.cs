using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicação
{
    public partial class Comunicacao : Form
    {
        public Comunicacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario f2 = new Formulario();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComunicaUDP f2 = new ComunicaUDP();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
