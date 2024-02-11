using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioCodigo_PWC_2024
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            String enderecoDigitado = textBox_Entrada.Text;
            MessageBox.Show(enderecoDigitado);
        }
    }
}
