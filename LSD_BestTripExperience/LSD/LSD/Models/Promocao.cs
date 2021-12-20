using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSD.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }
        public string DotPromo { get; set; }
  
        


        public int DestinoId { get; set; }
        [ForeignKey("DestinoId")]
        public virtual Destino Destino { get; set; }



    }



}
