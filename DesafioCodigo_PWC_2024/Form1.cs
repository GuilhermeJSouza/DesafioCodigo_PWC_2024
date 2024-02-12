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

        private void button_Confirmar_Click(object sender, EventArgs e)//Evento do click do botão
        {
            String enderecoDigitado = textBox_Entrada.Text.Replace(",", "");//Faz a leitura da entrada do usuário

            int y = enderecoDigitado.LastIndexOf(" No ");//Procura 'No' na entrada do usuário e passa para a variávevl y a posição

            string[] endereco = new string[1];//declaração da lista string do endereço
            string[] numero = new string[1];//declaração da lista string do número

            try
            {

                int result;//declaração da variável result o resultado da entrada do usuário convertido em número

                if (y > 0)//Condição se houver No na string de entrada do usuário
                {
                    endereco[0] = enderecoDigitado.Substring(0, y).Trim();//divide a string e coloca na lista endereco
                    numero[0] = enderecoDigitado.Substring(y, enderecoDigitado.Length - y).Trim();//divide a string e coloca na lista numero
                }
                /*else if (y == 0)
                {
                    numero[0] = enderecoDigitado.Substring(0, y).Trim();
                    endereco[0] = enderecoDigitado.Substring(y, enderecoDigitado.Length - y).Trim();
                }*/
                else if (y == -1)
                {
                    for (int x = enderecoDigitado.IndexOf(" "); x < enderecoDigitado.Length; x++) // Iteração para encontrar todos os espaços da
                                                                                                  // frase
                    {

                        if (enderecoDigitado[x] == ' ' && int.TryParse(enderecoDigitado[x + 1].ToString(), out result))//condição se houver um espaço e próximo elemnto for um número
                        
                        {
                            endereco[0] = enderecoDigitado.Substring(0, x).Trim();
                            numero[0] = enderecoDigitado.Substring(x, enderecoDigitado.Length - x).Trim();
                            break;//interrompe o for
                        }
                        else if (enderecoDigitado[x] == ' ' && int.TryParse(enderecoDigitado[x - 1].ToString(), out result))
                        {
                            numero[0] = enderecoDigitado.Substring(0, x).Trim();
                            endereco[0] = enderecoDigitado.Substring(x, enderecoDigitado.Length - x).Trim();
                            break;//interrompe o for
                        }
                    }
                }
            }

            catch
            {
                MessageBox.Show("Endereço inválido!");

                endereco[0] = "";//Limpa em caso de erro
                numero[0] = "";//Limap em caso de erro

                //textBox_Entrada.Text = string.Empty;
            }

            label_endereco_saida.Text = endereco[0].Replace(",", "");
            label_numero_saida.Text = numero[0];

        }
    }
}
