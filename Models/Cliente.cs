using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProjeto365.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_id { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public DateTime  Nascimento { get; set; }

        public virtual ICollection<Passagem> Id_passagem { get; set; }
    }
}
