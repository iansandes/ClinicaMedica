using ClinicaMedica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Repositories.Contracts
{
    public interface IConsultaRepository : IDisposable
    {
        List<Consulta> Get();
        Consulta GetById(int id);
        bool Create(Consulta consulta);
        bool Update(Consulta consulta);
        void Delete(int id);
    }
}
