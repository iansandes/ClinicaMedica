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
    public class MedicoRepository : IMedicoRepository
    {
        private ClinicaMedicaDataContext _db = new ClinicaMedicaDataContext();

        // Criação das funções CRUD do Database usando o EntityFramework
        public bool Create(Medico medico)
        {
            try
            {
                _db.Medicos.Add(medico);
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
            var medico = _db.Medicos.Find(id);
            _db.Medicos.Remove(medico);
            _db.SaveChanges();
        }

        public List<Medico> Get()
        {
            return _db.Medicos.ToList();
        }

        public Medico GetById(int id)
        {
            return _db.Medicos.Find(id);
        }

        public List<Medico> GetByName(string name)
        {
            var medico = _db.Medicos.Where(x => x.Nome.Contains(name)).ToList();
            return medico;
        }

        public bool Update(Medico medico)
        {
            try
            {
                _db.Entry<Medico>(medico).State = EntityState.Modified;
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