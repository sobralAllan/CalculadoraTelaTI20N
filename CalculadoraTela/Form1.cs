﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();
        }//fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numeroUm_TextChanged(object sender, EventArgs e)
        {

        }//fim do input de numeroUm

        private void numeroDois_TextChanged(object sender, EventArgs e)
        {

        }//fim do input de numeroDois

        private void somar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Somar(num1, num2);
            }
        }//fim do botão somar

        private void subtrair_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }//fim do botão subtrair

        private void limpar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                numeroUm.Text = "";
                numeroDois.Text = "";
                resultado.Text = "";
            }
        }//fim do limpar

        private void dividir_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    resultado.Text = "Impossível Dividir";
                }
                else
                {
                    resultado.Text = "" + modelo.Dividir(num1, num2);
                }
            }
        }//fim do dividir

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//fim do multiplicar

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }//fim do resultado
    }//fim da classe
}//fim do projeto
