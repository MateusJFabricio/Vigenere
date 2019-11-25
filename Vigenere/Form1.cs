using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        Vigenere vigenere = new Vigenere();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            vigenere.CarregarPalavrasIngles();
            vigenere.CarregarPalavrasPortugues();
        }

        private void btnDescriptComChave_Click(object sender, EventArgs e)
        {
            if (txtChave.TextLength <= 0)
            {
                MessageBox.Show("Digite uma chave");
                return;
            }

            if (txtChave.TextLength != 3)
            {
                MessageBox.Show("A chave deve ter 3 letras somente");
                return;
            }

            rtTextoDescriptografado.Clear();
            rtTextoDescriptografado.Text = vigenere.Descriptografar(rtTextoCriptografado.Text, txtChave.Text);
        }

        private void btnDescriptSemChave_Click(object sender, EventArgs e)
        {
            rtPossiveisResultados.Clear();
            rtPossiveisResultados.Text = "Descriptografando...";
            foreach (var result in vigenere.DescriptografarSemChave(rtTextoCriptografado.Text))
            {
                rtPossiveisResultados.AppendText(result);
            }
        }
    }
}
