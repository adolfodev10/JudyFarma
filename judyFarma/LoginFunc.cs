using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace judyFarma
{
    public partial class LoginFunc : Form
    {
        public LoginFunc()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt1.Text != "" && txt2.Text != "")
                {
                    string string_conexao = "server=localhost;uid=root;database=judyfarma;Sslmode=none";

                    string Nome = txt1.Text;
                    string Senha = txt2.Text;
                    bool verificar = false;

                    MySqlConnection ligacao = new MySqlConnection(string_conexao);
                    ligacao.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM funcionario", string_conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    foreach (DataRow linha in tabela.Rows)
                    {
                        if (linha["nome"].ToString() == Nome && linha["senha"].ToString() == Senha)
                        {
                            verificar = true;
                            break;
                        }
                        else
                        {
                            verificar = false;
                        }
                    }
                    if (verificar == true)
                    {
                        string textoDigitado = txt1.Text;

                        Dashboard h = new Dashboard(textoDigitado);
                        this.Hide();
                        h.ShowDialog();
                        txt1.Text = string.Empty;
                        txt2.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Esta Conta não existe ! Crie uma Conta");
                        Limpar();
                    }
                }
                else if (txt1.Text == "" && txt2.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos Vazios!!!");
                }
                else if (txt1.Text == "")
                {
                    MessageBox.Show("Coloque o Nome");
                }
                else if (txt2.Text == "")
                {
                    MessageBox.Show("Coloque a Senha");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }
        public void Limpar()
        {
            txt1.Text = "";
            txt2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUpFunc s = new SignUpFunc();
            this.Hide();
            s.ShowDialog();
        }
    }
    }