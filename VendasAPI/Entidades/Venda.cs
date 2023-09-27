using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VendasAPI.Entidades
{
    public class Venda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdVenda { get; set; }

        [BsonElement("Name")]
        public string Nome_cliente { get; set; }
        public decimal Preco_total { get; set; }
        public string Nome_produto { get; set; }
        public int Quantidade_produto { get; set; }

    }
}
