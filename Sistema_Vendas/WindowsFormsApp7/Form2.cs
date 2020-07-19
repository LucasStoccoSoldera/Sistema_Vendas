using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text =
            "Símbolo: " + Class1.simbolo + Environment.NewLine + 
            "Nome: " + Class1.nome + Environment.NewLine +
            "Número Atômico: " + Class1.numAtomico + Environment.NewLine +
            "Número de Massa: " + Class1.numMassa; 
            pictureBox1.Image = Image.FromFile(Class1.endImagem);
            this.Text = Class1.nome;
        }
    }
}
