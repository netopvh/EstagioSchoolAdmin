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
    public sealed class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("pessoas", "public");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("pes_pk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName("pes_nome")
                .HasMaxLength(64)
                .IsRequired();

            Property(x => x.Sexo)
               .HasColumnName("pes_sexo")
               .HasMaxLength(1)
               .IsRequired();

            Property(x => x.DataNascimento)
               .HasColumnName("pes_datanascimento")
               .IsRequired();

            Property(x => x.Rg)
               .HasColumnName("pes_rg")
               .HasMaxLength(64)
               .IsRequired();

            Property(x => x.Ativo)
               .HasColumnName("pes_ativo");
        }
    }
}
