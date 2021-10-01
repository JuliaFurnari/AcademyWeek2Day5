using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        List<Arma> Arma { get; set; }
        List<Eroe> Eroe { get; set; }
        List<Mostro> Mostro { get; set; }
        public TipoPersonaggio Tipo { get; set; }
       


    }
    public enum TipoPersonaggio
    {
        Guerriero = 1,
        Mago = 2,
        Cultista = 3,
        Orco = 4,
        SignoreDelMale =5,
    }


}
