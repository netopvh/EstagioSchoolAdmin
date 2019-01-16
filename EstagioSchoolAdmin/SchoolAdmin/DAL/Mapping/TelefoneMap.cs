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

            Property(x => x.PessoaId)
               .HasColumnName("pes_pk")
               .IsRequired();

            HasRequired(x => x.Pessoa)
                .WithMany(x => x.Telefones)
                .HasForeignKey(c => c.PessoaId);
        }
    }
}
