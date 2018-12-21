﻿using SchoolAdmin.DAL.Mapping;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.DAL
{
    class ContextoDB : DbContext
    {
        public ContextoDB() : base("name=escola")
        {
            try
            {
                Configuration.LazyLoadingEnabled = false;
                Configuration.ProxyCreationEnabled = false;
                Database.SetInitializer<DbContext>(null);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DbSet<CargoFuncionario> CargosMap { get; set; }
        public DbSet<Pessoa> PessoaMap { get; set; }
        public DbSet<Funcionario> FuncionariosMap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CargoFuncionarioMap());
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
        }

    }
}
