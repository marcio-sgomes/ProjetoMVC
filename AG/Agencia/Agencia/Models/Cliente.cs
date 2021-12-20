using Agencia.Enum;
using System;

namespace Agencia.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }    
        public string Endereco { get; set; }    
        public DateTime Nascimento { get; set; }
        public Situacao Situacao { get; set; }
    }
}
