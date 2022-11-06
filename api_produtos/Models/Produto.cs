using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_produtos.Models
{
    [Table(name:"produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
