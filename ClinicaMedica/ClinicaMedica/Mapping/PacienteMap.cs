﻿using ClinicaMedica.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ClinicaMedica.Mapping
{
    public class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            ToTable("Paciente");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.Idade).IsRequired();
            Property(x => x.Sexo).IsRequired();
            Property(x => x.DataNascimento).IsRequired();
            Property(x => x.Telefone);
        }
    }
}