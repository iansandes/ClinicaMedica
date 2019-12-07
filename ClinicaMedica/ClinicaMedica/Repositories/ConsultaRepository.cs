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
    public class ConsultaRepository : IConsultaRepository
    {
        private ClinicaMedicaDataContext _db = new ClinicaMedicaDataContext();
        // Criação das funções CRUD do Database usando o EntityFramework

        public bool Create(Consulta consulta)
        {
            try
            {
                _db.Consultas.Add(consulta);
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
            var consulta = _db.Consultas.Find(id);
            _db.Consultas.Remove(consulta);
            _db.SaveChanges();
        }  

        public List<Consulta> Get()
        {
            return _db.Consultas.ToList();
        }

        public Consulta GetById(int id)
        {
            return _db.Consultas.Find(id);
        }

        public bool Update(Consulta consulta)
        {
            try
            {
                _db.Entry<Consulta>(consulta).State = EntityState.Modified;
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