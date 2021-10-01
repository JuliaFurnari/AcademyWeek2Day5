using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int PuntiDanno { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public TipoArma Tipo { get; set; }
    }

    public enum TipoArma
    {
        //Guerriero
        Alabarda = 1,
        Ascia = 2,
        Mazza = 3,
        Spada = 4,
        Spadone = 5,

        //Mago
        
      ArcoFrecce = 6, // -> 8 punti danno
       Bacchetta = 7, // 5 punti danno
     BastoneMagico = 8, //  10 punti danno
      OndaUrto = 9, // 15 punti danno
       Pugnale = 10, // 5 punti danno

      //Armi per cultista
       DiscorsoNoioso = 11, // -> 4 punti danno
       Farneticazione = 12, // -> 7 punti danno
        Imprecazione = 13, //-> 5 punti danno
        MagiaNera = 14, // -> 3 punti danno

       //Armi per orco
          Arco = 15, // 7 punti danno
         Clava = 16, // -> 5 punti danno
       SpadaRotta = 17, // -> 3 punti danno
       MazzaChiodata=18, // 10 punti danno

      //Armi per Signore del male
      AlabardaDelDrago = 19, //-> 30 punti danno
      Divinazione = 20, // -> 15 punti danno
      Fulmine = 21, // -> 10 punti danno
      FulmineCeleste = 22, // -> 15 punti danno
      Tempesta = 23, // -> 8 punti danno
      TempestaOscura = 24, // -> 15 punti danno
    }
}
