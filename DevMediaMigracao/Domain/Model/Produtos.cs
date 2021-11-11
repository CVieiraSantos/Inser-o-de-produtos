using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMediaMigracao.Domain.Model
{
    [Table("Produtos")]
    public class Produtos
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage ="É permitido até 100 caracteres no campo Nome")]        
        public string Nome { get; set; }
        [Required]
        [Range(10.0, 500.0, ErrorMessage ="O valor do preço precisa estar entre R$ 10.00 e R$ 500.00")]
        public decimal Preco { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "O campo marca precisa conter no máximo 10 caracteres")]
        public string Marca { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public  DateTime DataCompra { get; set; }

    }
}
