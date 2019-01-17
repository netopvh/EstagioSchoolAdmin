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
    class EnderecosMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecosMap()
        {
            ToTable("estados", "public");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("end_pk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Rua)
              .HasColumnName("end_rua")
              .HasMaxLength(128)
              .IsRequired();

            Property(x => x.Numero)
                .HasColumnName("end_numero")
                .IsRequired();

            Property(x => x.Complemento)
              .HasColumnName("end_complemento")
              .HasMaxLength(128);

            Property(x => x.Cidade)
              .HasColumnName("end_cidade")
              .HasMaxLength(64)
              .IsRequired();

            Property(x => x.CEP)
              .HasColumnName("end_cep")
              .HasMaxLength(128)
              .IsRequired();

            Property(x => x.Bairro)
              .HasColumnName("end_bairro")
              .HasMaxLength(64)
              .IsRequired();

            Property(x => x.EstadoId)
               .HasColumnName("est_pk")
               .IsRequired();

            HasRequired(x => x.Estado)
                .WithMany(x => x.Enderecos)
                .HasForeignKey(c => c.EstadoId);

            Property(x => x.PessoaId)
               .HasColumnName("pes_pk")
               .IsRequired();

            HasRequired(x => x.Pessoa)
                .WithMany(x => x.Enderecos)
                .HasForeignKey(c => c.PessoaId);
        }
    }
}
