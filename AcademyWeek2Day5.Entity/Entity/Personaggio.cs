using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    abstract public class Personaggio
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }




    }
  

   
}
