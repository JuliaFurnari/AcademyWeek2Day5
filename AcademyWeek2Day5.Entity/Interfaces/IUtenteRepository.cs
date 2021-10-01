using AcademyWeek2Day5.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.Entity.Interfaces
{
    public interface IUtenteRepository:IRepository<Utente>
    {
        Utente GetByNickname(string nickname);
    }
}
