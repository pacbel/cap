using cap.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Models
{
    public class ContaPagar : Padroes
    {
        public StatusConta  Status { get; set; }
        public Guid IdPessoaAprovadora { get; set; }
        public Guid IdCompra { get; set; }
        public DateTime DataVencimento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorLcto { get; set; }
        public Guid IdPessoaFinanceiro { get; set; }
        public DateTime DataPagamento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Juros { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Multa { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Correcao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorPgto { get; set; }

    }
}
