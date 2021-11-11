using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevMediaMigracao.Domain.Model
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TelefoneContato { get; set; }
        public string Email { get; set; }

        public Cliente(int id, string nome, string telefoneContato, string email)
        {
            Id = id;
            Nome = nome;
            TelefoneContato = telefoneContato;
            Email = email;
        }

        public Cliente() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: ");
            sb.AppendLine(Id.ToString());
            sb.Append("Nome: ");
            sb.AppendLine(Nome);
            sb.Append("Telefone: ");
            sb.AppendLine(TelefoneContato);
            sb.Append("Email: ");
            sb.AppendLine(Email);
            return sb.ToString();

        }
    }
}
