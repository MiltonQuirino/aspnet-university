using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InsperUniversity.Models
{
    public class Schedule
    {
        public int ID { get; set; }

        public string Tipo { get; set; }

        [Required]
        [Display(Name = "Hora Inicio")]
        public string Start { get; set; }

        [Required]
        [Display(Name = "Hora fim")]
        public string End { get; set; }

        [Required]
        [Display(Name = "Dia")]
        public string Day { get; set; }
    }
}