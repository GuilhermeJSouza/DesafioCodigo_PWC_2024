namespace DesafioCodigo_PWC_2024
{
    partial class Form_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Instruction = new System.Windows.Forms.Label();
            this.textBox_Entrada = new System.Windows.Forms.TextBox();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label_Endereco = new System.Windows.Forms.Label();
            this.label_Numero = new System.Windows.Forms.Label();
            this.label_endereco_saida = new System.Windows.Forms.Label();
            this.label_numero_saida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Location = new System.Drawing.Point(12, 9);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(117, 16);
            this.label_Instruction.TabIndex = 0;
            this.label_Instruction.Text = "Digite o endereço.";
            // 
            // textBox_Entrada
            // 
            this.textBox_Entrada.Location = new System.Drawing.Point(15, 40);
            this.textBox_Entrada.Name = "textBox_Entrada";
            this.textBox_Entrada.Size = new System.Drawing.Size(470, 22);
            this.textBox_Entrada.TabIndex = 1;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(15, 83);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(138, 64);
            this.button_Confirmar.TabIndex = 2;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // label_Endereco
            // 
            this.label_Endereco.AutoSize = true;
            this.label_Endereco.Location = new System.Drawing.Point(18, 176);
            this.label_Endereco.Name = "label_Endereco";
            this.label_Endereco.Size = new System.Drawing.Size(69, 16);
            this.label_Endereco.TabIndex = 3;
            this.label_Endereco.Text = "Endereço:";
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Location = new System.Drawing.Point(18, 229);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(58, 16);
            this.label_Numero.TabIndex = 4;
            this.label_Numero.Text = "Número:";
            // 
            // label_endereco_saida
            // 
            this.label_endereco_saida.AutoSize = true;
            this.label_endereco_saida.Location = new System.Drawing.Point(93, 176);
            this.label_endereco_saida.Name = "label_endereco_saida";
            this.label_endereco_saida.Size = new System.Drawing.Size(11, 16);
            this.label_endereco_saida.TabIndex = 5;
            this.label_endereco_saida.Text = "-";
            // 
            // label_numero_saida
            // 
            this.label_numero_saida.AutoSize = true;
            this.label_numero_saida.Location = new System.Drawing.Point(82, 229);
            this.label_numero_saida.Name = "label_numero_saida";
            this.label_numero_saida.Size = new System.Drawing.Size(11, 16);
            this.label_numero_saida.TabIndex = 6;
            this.label_numero_saida.Text = "-";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_numero_saida);
            this.Controls.Add(this.label_endereco_saida);
            this.Controls.Add(this.label_Numero);
            this.Controls.Add(this.label_Endereco);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.textBox_Entrada);
            this.Controls.Add(this.label_Instruction);
            this.Name = "Form_Main";
            this.Text = "Provedor de Endereços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.TextBox textBox_Entrada;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Label label_Endereco;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.Label label_endereco_saida;
        private System.Windows.Forms.Label label_numero_saida;
    }
}

