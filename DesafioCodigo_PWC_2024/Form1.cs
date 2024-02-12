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
using System.Text.RegularExpressions;

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

            //##########################################     CASO 1     ########################################################

            /*string[] ruaNumero = enderecoDigitado.Split(' ');// Dividindo a string no espaço em branco e atribuindo à um array

            String rua = ruaNumero[0];

            label_endereco_saida.Text = rua.Replace(",", "");//Atribui o texto à label de saída endereço removendo possíveis vírgulas
            
            label_numero_saida.Text = ruaNumero[1];//Atribui o texto à label de saída número*/

            //##########################################     CASO 2     ###################################################################

            //enderecoDigitado.Split(' ');
            //string[] ruaNumero = new string[2];
            //ruaNumero = enderecoDigitado.Split(' ');

            //List<String> separadores = new List<String>();//Declara uma lista para as posições onde tem espaço na string de entrada

            string[] endereco = new string[1];
            string[] numero = new string[1];

            //separadores.Add(0); // Inicia a lista

            //int separadores = enderecoDigitado.IndexOf(" "); // adiciona na posição zero a posição do primeiro retorno de espaço

            for (int x = enderecoDigitado.IndexOf(" "); x < enderecoDigitado.Length; x++) // Iteração para encontrar todos os espaços da
                                                                          // frase
            {
                //if (enderecoDigitado.Substring(x, x + 1).Equals(" ") && enderecoDigitado.Substring(x + 1, x + 2).ToString() == "2")
                if (enderecoDigitado[x] == ' ' && enderecoDigitado[x + 1] == '2')
                {
                    endereco[0] = enderecoDigitado.Substring(0, x);
                    numero[0] = enderecoDigitado.Substring(x + 1, enderecoDigitado.Length-1-x);
                    break;
                }
            }
            label_endereco_saida.Text = endereco[0];
            label_numero_saida.Text = numero[0];
        }
    }
}
