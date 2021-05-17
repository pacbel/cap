using cap.Business.Entities;
using cap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cap.Data.Mappings
{
    public class ContaPagarMapping : IEntityTypeConfiguration<ContaPagar>
    {
        public void Configure(EntityTypeBuilder<ContaPagar> builder)
        {
            builder.ToTable("TB_CONTA_PAGAR");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Codigo).ValueGeneratedOnAdd();
            builder.Property(p => p.DataHoraModificacao);
            builder.Property(p => p.IdCompra);
            builder.Property(p => p.IdPessoaAprovadora);
            builder.Property(p => p.IdPessoaFinanceiro);
            builder.Property(p => p.ValorLcto);
            builder.Property(p => p.ValorPgto);
            builder.Property(p => p.Correcao);
            builder.Property(p => p.Multa);
            builder.Property(p => p.Juros);
            builder.Property(p => p.Status);
            builder.Property(p => p.DataPagamento);
            builder.Property(p => p.DataVencimento);
        }
    }
}
