using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class estados_equipos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_estados_equipos { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
    }
}
