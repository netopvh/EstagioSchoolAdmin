using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.DAL.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("funcionarios", "public");

            Property(x => x.CPF)
                .HasColumnName("fun_cpf")
                .HasMaxLength(16).IsRequired();

            Property(x => x.Email)
                .HasColumnName("fun_email")
                .HasMaxLength(64);

            Property(x => x.Admissao)
                .HasColumnName("fun_admisssao")
                .IsRequired();

            Property(x => x.Demissao)
                .HasColumnName("fun_desligamento");

            Property(x => x.Observacoes)
                .HasColumnName("fun_observacoes")
                .HasMaxLength(256);

            Property(x => x.Salario)
                .HasColumnName("fun_salario")
                .IsRequired();

            Property(x => x.CargoId)
                .HasColumnName("car_pk")
                .IsRequired();

            HasRequired(x => x.Cargo)
                .WithMany(x => x.Funcionarios)
                .HasForeignKey(c => c.CargoId);
        }
    }
}
