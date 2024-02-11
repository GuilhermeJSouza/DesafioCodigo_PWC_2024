using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            String enderecoDigitado = textBox_Entrada.Text;//Faz a leitura da entrada do usuário

            //enderecoDigitado.Split(' ');
            //string[] ruaNumero = new string[2];
            //ruaNumero = enderecoDigitado.Split(' ');
            
            string[] ruaNumero = enderecoDigitado.Split(' ');// Dividindo a string no espaço em branco e atribuindo à um array

            foreach (string parte in ruaNumero)//Imprimindo cada string do array
            {
                Console.WriteLine(parte);
            }

            //Console.WriteLine("Teste");
            //Console.WriteLine(enderecoDigitado.Split(' '));

            //MessageBox.Show(enderecoDigitado.Split(' '));
        }
    }
}
