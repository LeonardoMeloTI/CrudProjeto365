using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProjeto365.Models
{
    public class Cliente
    {   [Key]
        public int Pessoa_id { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}
