using cap.Enums;
using System;
using System.Collections.Generic;

namespace cap.Business.Entities
{
    public class PessoaFisica
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public PessoaPapel Papel { get; set; }
        public PessoaTipo Tipo { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public bool SemNumero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public StatusTipo Status { get; set; }
        public DateTime DataHoraModificacao { get; set; }
    }
}
