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
    class EstadosMap : EntityTypeConfiguration<Estado>
    {
        public EstadosMap()
        {
            ToTable("estados", "public");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("est_pk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName("est_nome")
                .HasMaxLength(64)
                .IsRequired();

            Property(x => x.Sigla)
               .HasColumnName("est_sigla")
               .HasMaxLength(2)
               .IsRequired();
        }
    }
}
