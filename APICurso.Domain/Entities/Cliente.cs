﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.Entities
{
    public class Cliente
    {
        //Os private set serve para a proteger de alteraçoes o cliente sem que seja gerado log
        public int Codigo { get; private set; } 
        public double LimiteCredito { get; private set; }
        public string Nome { get; private set; }
        public bool IsActive { get; private set; }
        public int IdLog { get; private set; } 

        public Cliente()
        {

        }

        //metodo para Alterar o limite de credito
        public void AlterarLimiteDeCredito(double valor, bool subtrair, int idLog)
        {
            if (subtrair)//Verifica se é para subtrair ou somar ao limite de credito já existente
            {
                this.LimiteCredito -= valor;
                this.IdLog = idLog;
            }
            else
            {
                this.LimiteCredito += valor;
                this.IdLog = idLog;
            }
        }

        //metodo para cadastrar novo cliente
        public void CadastrarNovoCliente(string nome, double limite, int idLog, int codigo)
        {
            this.Codigo = codigo;
            this.IdLog = idLog;
            this.Nome = nome;
            this.LimiteCredito = limite;
            this.IsActive = true;
        }

        //metodo para alterar o nome do cliente
        public void AlterarNomeCliente(string nome ,int idLog)
        {
            this.IdLog = idLog;
            this.Nome = nome;
        }


    }
}