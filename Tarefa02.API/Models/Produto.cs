namespace Tarefa02.API.Model
{
    public class Produto
    {
        public int? ProdutoId { get; set; }

        public string? Nome { get; set; }

        public decimal? Preco { get; set; }

        public int? Quantidade { get; set; }

        public Produto (){
        }

        public Produto (int? id, string nome, decimal preco, int quantidade){
            ProdutoId = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}