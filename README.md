1) Crie um projeto chamado APICurso. Este projeto deve ser uma WebAPI do tipo .Net Framework ou .Net Core.

2) Crie uma tabela no BD chamada "LimiteCliente" onde deve-se cadastrar o c�digo do cliente, nome e o valor de seu limite de cr�dito. Inclua 10 linhas com seus respectivos clientes. 

2.1) Tanto a cria��o da tabela quanto os Insert para a mesma, devem ser salvos em um script "BDServico.sql"

3) No projeto WebAPI, crie uma rotina que ao receber o c�digo do cliente, retorne seu respectivo Limite de Credito.

3.1) Crie no WebAPI uma outra rotina que ao receber o codigo do cliente e um valor qualquer, decrementa este valor do Limite de Cr�dito do Cliente em quest�o.

4) Crie um projeto chamado APICliente. Este projeto deve ser um sistema Web MVC

4.1) Crie uma tabela no BD chamada "VendasCliente" onde deve-se cadastrar o c�digo do cliente, a data da venda e o valor da venda. Esta tabela deve ter seu c�digo de cria��o em um script "BDCliente.sql"

4.2) Crie uma View, que permita ao usu�rio "Vender" para o cliente, desde que ele tenha limite de cr�dito.

5) Fa�a este projeto consultar a o limite de cr�dito na WebAPI, com a seguinte l�gica de neg�cio:

- Na tela, APICliente recebe o c�digo do cliente e o valor da venda
- APICliente consulta o c�digo do cliente, buscando o valor de limite de cr�dito na WEBApi
- Se valor da venda > limite, aparece uma tela avisando que a venda n�o pode ser feita
- Se valor da venda <=  limite, APICliente cadastra uma linha na tabela "VendasCliente"
- Se venda realizada, APICliente avisa WEBApi o valor da venda
- WEBApi retira o limite de cr�dito do cliente

6) Salve os dois projetos no Git Hub