using ClinicaMedica.Context;
using ClinicaMedica.Domain;
using ClinicaMedica.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicaMedica.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private ClinicaMedicaDataContext _db = new ClinicaMedicaDataContext();
        // Criação das funções CRUD do Database usando o EntityFramework
        public bool Create(Paciente paciente)
        {
            try
            {
                _db.Pacientes.Add(paciente);
                _db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var paciente = _db.Pacientes.Find(id);
            _db.Pacientes.Remove(paciente);
            _db.SaveChanges();
        }

        public List<Paciente> Get()
        {
            return _db.Pacientes.ToList();
        }

        public Paciente GetById(int id)
        {
            return _db.Pacientes.Find(id);
        }

        public List<Paciente> GetByName(string name)
        {
            var paciente = _db.Pacientes.
                Where(x => x.Nome.Contains(name)).ToList();
            return paciente;
        }

        public bool Update(Paciente paciente)
        {
            try
            {
                _db.Entry<Paciente>(paciente).State = EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}