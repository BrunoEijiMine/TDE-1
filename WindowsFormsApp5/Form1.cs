﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           for(int data = 2020; data > 1910; data--)
            {
                combAno.Items.Add(data);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtSobrenome.ResetText();
            txtEmail.ResetText();
            combSexo.SelectedIndex = -1;
            txtCPF.ResetText();
            combDia.SelectedIndex = -1;
            combMes.SelectedIndex = -1;
            combAno.SelectedIndex = -1;
            txtSenha.ResetText();
            txtRepetirSenha.ResetText();

            MessageBox.Show("Formulario limpo.");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            mensagem += "Nome: " + txtNome.Text + " " + txtSobrenome.Text + "\n";
            mensagem += "Email: "+ txtEmail.Text + "\n";
            mensagem +="Sexo: "+ combSexo.Text + "\n";
            mensagem +="CPF:  "+ txtCPF.Text + "\n";
            mensagem +="Nascimento: "+ combDia.Text + "/" + combMes.Text + "/" + combAno.Text + "\n";
            mensagem +="Senha: "+ txtSenha.Text + "\n";
            mensagem +="RepetirSenha "+ txtRepetirSenha.Text + "\n";
            MessageBox.Show(mensagem);
           

        }
    }
}
