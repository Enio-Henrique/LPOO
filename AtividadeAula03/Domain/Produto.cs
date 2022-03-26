// Identifique	 as classes e implemente um	
//  programa para a seguinte especificação:
// “O	 supermercado	 vende	 diferentes 
// tipos de produtos.	 Cada	 produto tem
// um preço e uma	 quantidade em estoque.
// Um	pedido	de um	cliente	é composto de 
// itens,	onde	cada item  específica o	produto 
// que o cliente deseja e a respectiva quantidade.
// Esse pedido pode ser pago em dinheiro, cheque ou 
// cartão.” 


namespace AtividadeAula03.Domain
{

    public class Produto{
        public Produto(int id, string nome, double qtdEstoque, double preco)
        {
            this.Id = id;
            Nome = nome;
            QtdEstoque = qtdEstoque;
            Preco = preco;
        }

        

        public int Id { get; private set; }
        public string Nome { get;set; }

        public double QtdEstoque { get; set; } = 0;

        public double Preco { get; set; } = 0;
    }
       
    
}
