using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSD.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public ICollection <Promocao> Promocao { get; set; }

    }
}
