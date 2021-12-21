using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProjeto365.Models
{
    public class Promocao
    {   [Key]
        public int Promocao_id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int Embarque { get; set; }
        public int Desembarque { get; set; }
        


    }
}
