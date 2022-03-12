using System;

namespace Aula02TestAmbiente.Entities
{
    public class Livro
    {
        private int id;
        string titulo;
        decimal valor;
        DateTime dataPublicacao;

        public Livro(int id, string titulo, string Autor){
            this.id = id;
            this.titulo = titulo;
            this.Autor = Autor;
        }

        public int GetId(){
            return this.id;
        }

        public string GetTitulo(){
            return this.titulo;
        }

        public decimal Valor{get; set; }

         public decimal GetValor(){
            if(this.valor == 0 ){
                return 0;

            }else{
                return valor;
            }
        }

        public void SetValor(decimal valor){
             this.valor = valor;
        }


    }
}