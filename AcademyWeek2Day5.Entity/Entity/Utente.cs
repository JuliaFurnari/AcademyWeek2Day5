using AcademyWeek2Day5.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcademyWeek2Day5.Entity
{
    public class Utente
    {
        public virtual int Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public bool Admin { get; set; }
        public virtual List<Eroe> Eroi { get; set; }



    }
}
