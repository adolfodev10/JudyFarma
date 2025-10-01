using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace judyFarma
{
    class bd : geral
    {
        protected override string Nome
        {
            get
            {
                return base.Nome;
            }

            set
            {
                base.Nome = value;
            }
        }
        protected override string Email
        {
            get
            {
                return base.Email;
            }

            set
            {
                base.Email = value;
            }
        }
        protected override int Telefone
        {
            get
            {
                return base.Telefone;
            }

            set
            {
                base.Telefone = value;
            }
        }
        protected override string Senha
        {
            get
            {
                return base.Senha;
            }

            set
            {
                base.Senha = value;
            }
        }

        public void CadastrarFuncionarios(string _nome, string _email, int _telefone, string _senha)
        {
            this.Nome = _nome;
            this.Email = _email;
            this.Telefone = _telefone;
            this.Senha = _senha;

            MySqlConnection conection = conexao();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conection.Open();
                comando.CommandText = "INSERT INTO funcionario VALUES(default,@nome,@email,@telefone,@senha)";
                comando.Parameters.AddWithValue("@nome", Nome);
                comando.Parameters.AddWithValue("@email", Email);
                comando.Parameters.AddWithValue("@telefone", Telefone);
                comando.Parameters.AddWithValue("@senha", Senha);
                comando.Connection = conection;
                comando.ExecuteNonQuery();
                conection.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conection.Close();
            }

        }
        protected override MySqlConnection conexao()
        {
            return base.conexao();
        }
    }
}
