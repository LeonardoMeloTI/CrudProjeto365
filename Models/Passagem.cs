using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProjeto365.Models
{
    public class Passagem
    {
        [Key]
        public int  Passagem_id { get; set; }
        public string Destino { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }
        public string Poltrona { get; set; }
        public string Classe { get; set; }
        public double Preço { get; set; }

        [ForeignKey("Cliente")]
        public int Cliente_id { get; set; }
        public virtual Contato Cliente { get; set; }




    }
}
