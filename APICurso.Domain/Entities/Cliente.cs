using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Domain.Entities
{
    public class Cliente
    {
        public int Codigo { get; private set; }//private set para evitar manipulaçao do codigo de cliente sem segurança 
        public double LimiteCredito { get; private set; }//private set para evitar manipulaçao do limite de cliente sem segurança
        public string Nome { get; private set; }

        public Cliente()
        {

        }

        //metodo para Alterar o limite de credito
        public void AlterarLimiteDeCredito(double valor, bool subtrair)
        {
            if (subtrair)//Verifica se é para subtrair ou somar ao limite de credito já existente
            {
                this.LimiteCredito -= valor; 
            }
            else
            {
                this.LimiteCredito += valor;
            }
        }

    }
}
