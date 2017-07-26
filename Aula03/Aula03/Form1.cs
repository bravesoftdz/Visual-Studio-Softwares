using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario, cidade;
            DateTime dataNascimento;
            bool generoM, generoF;
            int numeroCadastro;

            nomeUsuario = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBox1.Text;
            generoM = radioButton1.Checked;
            generoF = radioButton2.Checked;
            numeroCadastro = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de Nascimento: " + dataNascimento);
            if(generoM == true)
            {
                MessageBox.Show("Masculino");
            }
            else
            {
                MessageBox.Show("Feminino");
            }

            MessageBox.Show("Numero do Cadastro: " + numeroCadastro);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
