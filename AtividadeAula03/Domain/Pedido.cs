using System;
using System.Collections.Generic;

namespace AtividadeAula03.Domain
{
    public class Pedido
    {
        public Pedido(int id, DateTime data, Cliente cliente, List<Produto> produtos)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            Produtos = produtos;
            Pagamentos = new List<Pagamento>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }
        public List<Produto> Produtos  { get; set; }
        public List<Pagamento> Pagamentos  { get; set; }
        
    }
}