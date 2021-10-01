using AcademyWeek2Day5.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Entity
{
    public class BusinessLayer
    {
        private IUtenteRepository _utenteRepo;

        public BusinessLayer( )
        {
           
        }
        public BusinessLayer(IUtenteRepository utenteRepository)
        {
            _utenteRepo = utenteRepository;
        }

        public Utente ControllaUtente(string nick)
        {
            Utente u = _utenteRepo.GetByNickname(nick);
            return u;
        }

        public void AddUtente(Utente u)
        {
            _utenteRepo.Add(u);
        }
    }
}
