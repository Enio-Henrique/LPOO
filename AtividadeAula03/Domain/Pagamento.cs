namespace AtividadeAula03.Domain
{
   public class Pagamento
   {
        public Pagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
       public string Nome { get; set; }

        
    }
}