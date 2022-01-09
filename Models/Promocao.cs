using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace CrudProjeto365.Models
{
    public class Promocao
    {
        [Key]
        public int Passageiro_id { get; set; }
        public string Destino { get; set; }
        public string Dias { get; set; }
        public string Preco { get; set; }
        public DateTime Data { get; set; }

    }
}