using System;
using System.Collections.Generic;
using AtividadeAula03.Domain;

namespace AtividadeAula03
{
    class Program
    {
        static Pedido pedidoDoPedro;
        static void Main(string[] args)
        {   //Instancia dos produtos
            Produto produto= new Produto(01, "arroz", 2, 2.99);
            Produto produto2= new Produto(02, "feijao", 10, 5.99);
            Produto produto3= new Produto(03, "massa", 50, 1.99);
            Produto produto4= new Produto(04, "ovo", 30, 14.99);
            Produto produto5= new Produto(05, "miojo", 3, 2.99);
            //Intancia dos clientes
            Cliente cliente = new Cliente(01, "João");
            Cliente client2 = new Cliente(02, "Pedro");
            Cliente client3 = new Cliente(03, "Fulano de Tal");
            //Instancia dos pagamentos
            Pagamento fDinheiro = new Pagamento(01, "Dinheiro");
            Pagamento fcartao = new Pagamento(02, "Cartão");


            //Criando um pedido!!!
             pedidoDoPedro = new Pedido(
                01, 
                new DateTime(2022,03,01), 
                client2, 
                new List<Produto>()
                {
                    produto,
                    produto2
                });
            pedidoDoPedro.Produtos.Add(produto3);
            pedidoDoPedro.Pagamentos.Add(fDinheiro);
            pedidoDoPedro.Pagamentos.Add(fcartao);

            // incluir pedido
            ImprimirPedido();

        }
        private static void ImprimirPedido()
        {
            Console.WriteLine("Pedido do " + pedidoDoPedro.Cliente.Nome);
            Console.WriteLine("Data" + pedidoDoPedro.Data.ToString("dd/MM/yyyy"));
            Console.WriteLine("-----------------------------------------");
            foreach (var item in pedidoDoPedro.Produtos)
            {
                Console.WriteLine(item.Nome);

            }
            Console.WriteLine("-----------------------------------------");
            foreach (var item in pedidoDoPedro.Pagamentos)
            {
                 Console.WriteLine(item.Nome);
            }

        }
    }
}
