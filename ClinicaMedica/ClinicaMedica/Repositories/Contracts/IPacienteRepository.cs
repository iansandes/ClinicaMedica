using ClinicaMedica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica.Repositories.Contracts
{
    public interface IPacienteRepository : IDisposable
    {
        List<Paciente> Get();
        Paciente GetById(int id);
        List<Paciente> GetByName(string name);
        bool Create(Paciente paciente);
        bool Update(Paciente paciente);
        void Delete(int id);

    }
}