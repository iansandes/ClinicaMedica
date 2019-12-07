using ClinicaMedica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica.Repositories.Contracts
{
    public interface IMedicoRepository : IDisposable
    {
        List<Medico> Get();
        Medico GetById(int id);
        List<Medico> GetByName(string name);
        bool Create(Medico medico);
        bool Update(Medico medico);
        void Delete(int id);
    }
}