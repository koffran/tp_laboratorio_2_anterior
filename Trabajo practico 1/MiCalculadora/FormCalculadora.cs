using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TP;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Franco Zarate del curso 2°A"; // Título

            txtNum1.TabIndex = 1;
            txtNum1.TabStop = true;
            cmbOperador.TabIndex = 2;
            cmbOperador.TabStop = true;
            txtNum2.TabIndex = 3;
            txtNum2.TabStop = true;

            button1.Text = "Operar";
            button1.TabIndex = 4;
            button1.TabStop = true;

            button2.Text = "Limpiar";
            button2.TabIndex = 5;
            button2.TabStop = true;

            button3.Text = "Cerrar";
            button3.TabIndex = 6;
            button3.TabStop = true;

            ConvertirABinario.Text = "Convertir a Binario";
            ConvertirABinario.TabIndex = 7;
            ConvertirABinario.TabStop = true;
            ConvertirADecimal.Text = "Convertir a Decimal";
            ConvertirADecimal.TabIndex = 8;
            ConvertirADecimal.TabStop = true;

            //cmbOperador
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");

            lblResultado.Text = "RESULTADO";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Calculadora calc = new Calculadora();
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            retorno = calc.Operar(num1, num2, operador);

            return  retorno;
        }


        private void button1_Click(object sender, EventArgs e)//OPERAR
        {
            lblResultado.Text = (Operar(txtNum1.Text, txtNum2.Text, cmbOperador.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)//LIMPIAR
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)//CERRAR
        {
            this.Close();
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void ConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            lblResultado.Text = num.DecimalBinario(txtNum1.Text);
        }

        private void ConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(txtNum1.Text);
        }
    }
}
