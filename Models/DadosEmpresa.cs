using System.ComponentModel.DataAnnotations.Schema;

namespace atv_api_23_09.Models
{
    [Table("dadosEmpresa")]
    public class DadosEmpresa
    {
        [Column("id_emp")]
        public int Id { get; set; }

        [Column("razao_social")]
        public required string RazaoSocial { get; set; }

        [Column("nome_fantasia")]
        public required string NomeFantasia { get; set; }

        [Column("cnpj")]
        public required string Cnpj { get; set; }

        [Column("inscricao_estadual")]
        public string? InscricaoEstadual { get; set; }

        [Column("telefone")]
        public required string Telefone { get; set; }

        [Column("email")]
        public required string Email { get; set; }

        [Column("cidade")]
        public required string Cidade { get; set; }

        [Column("estado")]
        public required string Estado { get; set; }

        [Column("cep")]
        public required string Cep { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; } // melhor usar DateTime
    }
}
