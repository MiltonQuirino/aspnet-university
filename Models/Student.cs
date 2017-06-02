using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InsperUniversity.Models
{
    public class Student 
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Classe")]
        public string Class { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Turma")]
        public string Team { get; set; }


        public virtual IList<Schedule> Schedule { get; set; }

        // horario de aula
        //public virtual Schedule FirstClassSchedule{ get; set; }
        //public virtual Schedule SecondClassSchedule { get; set; }

        ////horario de atendimento
        //public virtual Schedule FirstOfficeHours { get; set; }
        //public virtual Schedule SecondOfficeHours { get; set; }

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}