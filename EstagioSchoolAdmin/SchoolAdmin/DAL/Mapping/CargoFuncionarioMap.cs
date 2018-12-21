using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.DAL.Mapping
{
    public class CargoFuncionarioMap : EntityTypeConfiguration<CargoFuncionario>
    {
        public CargoFuncionarioMap()
        {
            ToTable("cargos_funcionarios", "public");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("car_pk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Cargo)
                .HasColumnName("car_cargo")
                .HasMaxLength(64)
                .IsRequired();
        }
    }
}
