using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_Farmacia.Entidades
{
    internal class Funcionario
    {
        //public static int proximoID = 1;
        //public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Cargo { get; set; }

        public Funcionario()
        {
            //ID = proximoID; //atribui automaticamente um ID ao criar um funcionário.
            //proximoID++; //incrementa o próximo ID disponível.
        }

        public Funcionario(/*int id,*/int id, string nome, string email, string senha, string cpf, DateTime data, string sexo, string cargo)
        {
            //this.ID = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Cpf = cpf;
            this.DataNascimento = data;
            this.Sexo = sexo;
            this.Cargo = cargo;
        }
    }
}