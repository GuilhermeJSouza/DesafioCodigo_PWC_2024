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
            String enderecoDigitado = textBox_Entrada.Text.Replace(",", "");//Faz a leitura da entrada do usuário

            //##########################################       CASO 1      ########################################################

            /*string[] ruaNumero = enderecoDigitado.Split(' ');// Dividindo a string no espaço em branco e atribuindo à um array

            String rua = ruaNumero[0];

            label_endereco_saida.Text = rua.Replace(",", "");//Atribui o texto à label de saída endereço removendo possíveis vírgulas
            
            label_numero_saida.Text = ruaNumero[1];//Atribui o texto à label de saída número*/

            //##########################################    CASOS 2 e 3   #########################################################

            int y = enderecoDigitado.LastIndexOf(" No ");

            //Console.WriteLine("teste");
            //Console.WriteLine(y);//Retorna -1 quando não tem No

            MessageBox.Show(y.ToString());

            //enderecoDigitado.Split(' ');
            //string[] ruaNumero = new string[2];
            //ruaNumero = enderecoDigitado.Split(' ');

            //List<String> separadores = new List<String>();//Declara uma lista para as posições onde tem espaço na string de entrada

            string[] endereco = new string[1];
            string[] numero = new string[1];

            //separadores.Add(0); // Inicia a lista

            //int separadores = enderecoDigitado.IndexOf(" "); // adiciona na posição zero a posição do primeiro retorno de espaço

            //Try
            int result;

            for (int x = enderecoDigitado.IndexOf(" "); x < enderecoDigitado.Length; x++) // Iteração para encontrar todos os espaços da
                                                                          // frase
            {

                //if (enderecoDigitado.Substring(x, x + 1).Equals(" ") && enderecoDigitado.Substring(x + 1, x + 2).ToString() == "2")
                if (enderecoDigitado[x] == ' ' && int.TryParse(enderecoDigitado[x + 1].ToString(), out result))
                //if (enderecoDigitado[x] == ' ' && enderecoDigitado[x + 1] == '0' || enderecoDigitado[x + 1] == '1' || enderecoDigitado[x + 1] == '2')
                {
                    endereco[0] = enderecoDigitado.Substring(0, x).Trim();
                    numero[0] = enderecoDigitado.Substring(x, enderecoDigitado.Length-x).Trim();
                    break;
                }
                else if (enderecoDigitado[x] == ' ' && int.TryParse(enderecoDigitado[x - 1].ToString(), out result))
                {
                    numero[0] = enderecoDigitado.Substring(0, x).Trim();
                    endereco[0] = enderecoDigitado.Substring(x, enderecoDigitado.Length - x).Trim();
                    break;
                }
            }
            label_endereco_saida.Text = endereco[0].Replace(",", "");
            label_numero_saida.Text = numero[0];
        }
    }
}
