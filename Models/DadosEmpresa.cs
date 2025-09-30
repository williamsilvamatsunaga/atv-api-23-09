using System.ComponentModel.DataAnnotations.Schema;

namespace atv_api_23_09.Models
{
    [Table("dadosEmpresa")]
    public class DadosEmpresa
    {
        [Column("id_emp")]
        public int Id { get; set; }

        [Column("razao_social")]
        public string RazaoSocial { get; set; }

        [Column("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Column("inscricao_estadual")]
        public string InscricaoEstadual { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; } // melhor usar DateTime
    }
}
