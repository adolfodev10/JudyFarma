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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ImgFlut.Top = 30;

            int cont = 1; 
               for(int i = 0; i<= cont; i++)
            {
                cont++;
                if (ImgFlut.Top == 30)
                {
                    Recursividade();
                }
            }
        } 
          public void Recursividade()
        {
            for(int i=0; i<100; i++)
            {
                int cont = 1;
                if(cont == 1)
                {
                    cont++;
                    ImgFlut.Top = cont + 30;
                }
                else
                {
                    cont++;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;uid=root;database=judyfarma;Sslmode=none";
            string produto = txtNome.Text;


            if(txtNome.Text == "" && txtPreco.Text == "" && txtQuant.Text == "" && txtDesc.Text == "")
            {
                MessageBox.Show("Preencha Tudo!");
            } 
            else if(txtNome.Text == "")
            {
                MessageBox.Show("Coloque o nome do Produto");
            }
            else if(txtPreco.Text == "")
            {
                MessageBox.Show("Coloque o preço do Produto");

            }
            else if (txtQuant.Text == "")
            {
                MessageBox.Show("Coloque a quantidade do Produto");

            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Coloque a descrição do Produto");

            }
            else
            {
                MySqlConnection ligacao = new MySqlConnection(conexao);
                ligacao.Open();

                var input = ligacao.CreateCommand();
                input.CommandText = $"INSERT INTO produto VALUES(default,'{txtNome.Text}','{txtPreco.Text}','{txtQuant.Text}','{txtDesc.Text}');";
                input.ExecuteNonQuery();

                Limpar();
                MessageBox.Show("Produto Adicionado co Sucesso!");
            }
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,preco,quantidade,descricao FROM produto", conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
        }
        public void Limpar()
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuant.Text = "";
            txtDesc.Text = "";
        }
    }
}
