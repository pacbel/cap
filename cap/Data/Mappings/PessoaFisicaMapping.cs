using cap.Business.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Data.Mappings
{
    public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.ToTable("TB_PESSOA_JURIDICA");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Codigo).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Tipo);
            builder.Property(p => p.RG);
            builder.Property(p => p.CPF);
            builder.Property(p => p.Papel);
            builder.Property(p => p.Status);
            builder.Property(p => p.Email);
            builder.Property(p => p.Telefone);
            builder.Property(p => p.DataHoraModificacao);
            builder.Property(p => p.Logradouro);
            builder.Property(p => p.Numero);
            builder.Property(p => p.SemNumero);
            builder.Property(p => p.Complemento);
            builder.Property(p => p.Bairro);
            builder.Property(p => p.CEP);
            builder.Property(p => p.Cidade);
            builder.Property(p => p.Estado);
            builder.Property(p => p.Status);
            

        }
    }
}
