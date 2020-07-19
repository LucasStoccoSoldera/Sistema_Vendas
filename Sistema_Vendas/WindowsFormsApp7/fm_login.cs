using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp7
{
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome_digitado;
            String senha_digitada, senha_q_vem_do_banco;

            senha_q_vem_do_banco = "";
            nome_digitado = tb_Usuario.Text;
            senha_digitada = tb_senha.Text;

            ClVariaveisGlobais.conexão.ConnectionString = 
                ClVariaveisGlobais.conecta;

            OleDbCommand comando = new OleDbCommand("SELECT * FROM tb_Usuario WHERE nome='" 
                + nome_digitado + "'");
            comando.Connection = ClVariaveisGlobais.conexão;
            ClVariaveisGlobais.conexão.Open();
            OleDbDataReader leitor = comando.ExecuteReader();
            while(leitor.Read())
            {
                senha_q_vem_do_banco = leitor.GetString(1);
            }
            ClVariaveisGlobais.conexão.Close();

            if (senha_q_vem_do_banco == senha_digitada)
                MessageBox.Show("OK");
            else
                MessageBox.Show("Usuário ou senha incorretos!");
            


        }

        private void fm_login_Load(object sender, EventArgs e)
        {
            this.Text = ClVariaveisGlobais.versãodoSistema;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
         this.Close();
        }
    }
}
