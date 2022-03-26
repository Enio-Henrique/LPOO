namespace AtividadeAula03.Domain
{
    public class Cliente
    {
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get;private set; }
        public string Nome { get;private set; }
        
    }
}