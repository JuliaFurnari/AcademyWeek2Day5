using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    public class Eroe:Personaggio
    {

        //  public int UtenteId { get; set; }


        public virtual List<Utente> Utenti { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
