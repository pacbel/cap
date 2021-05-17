using cap.Business.Entities;
using cap.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Models
{
    public class Compra : Padroes
    {
        public DateTime DataCompra { get; set; }
        public PessoaJuridica Fornecedor { get; set; }
        public PessoaFisica Comprador { get; set; }
        public CompraTipo ProdutoOuServico { get; set; }
        public string Discriminacao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorBruto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Retencoes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorLiquido { get; set; }
        public PagamentoTipo MeioPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Valor { get; set; }
        public byte[] Documento { get; set; }
    }
}
