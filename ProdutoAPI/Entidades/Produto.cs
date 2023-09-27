using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProdutoAPI.Entidades
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdProduto { get; set; }

        [BsonElement("Name")]
        public string Nome { get; set; }
        public string? Nome_fornecedor { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade_estoque { get; set; }
    }
}
