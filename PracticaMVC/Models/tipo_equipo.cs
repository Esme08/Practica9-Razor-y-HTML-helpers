using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descrición")]
        public string descripcion { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
    }
}
