using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace judyFarma
{
    class geral
    {
        //Cadastro de Funcionário
        protected virtual string Nome {get;set;}
        protected virtual string Email { get; set; }
        protected virtual int Telefone { get; set; }
        protected virtual string Senha { get; set; }



        //Base de Dados

        protected virtual MySqlConnection conexao()
        {
            string string_conexao = "server=localhost;uid=root;database=judyfarma;Sslmode=none";
            return new MySqlConnection(string_conexao);
        }

    }
}
