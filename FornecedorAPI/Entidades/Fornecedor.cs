using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FornecedorAPI.Entidades
{
    public class Fornecedor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdFornecedor { get; set; }

        [BsonElement("Name")]
        public string Nome { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

    }
}
