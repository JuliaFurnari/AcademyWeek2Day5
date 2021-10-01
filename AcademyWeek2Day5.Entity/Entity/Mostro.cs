using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    public class Mostro:Personaggio
    {
       // public int PuntiAccumulati { get; set; }
        //  public int UtenteId { get; set; }
        public int Id { get; set; }
        List<Utente> Utenti { get; set; }


        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
