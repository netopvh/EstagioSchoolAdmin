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
    class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
       public TelefoneMap()
        {
            ToTable("telefones", "public");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("tel_pk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Numero)
                .HasColumnName("tel_numero")
                .HasMaxLength(16);
        }
    }
}
