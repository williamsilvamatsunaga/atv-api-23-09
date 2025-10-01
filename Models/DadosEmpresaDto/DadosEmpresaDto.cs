using System.ComponentModel.DataAnnotations.Schema;

namespace atv_api_23_09.Models.DadosEmpresaTwo
{
    public class DadosEmpresaDto
    {
        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Cidade { get; set; }


        public string Estado { get; set; }


        public string Cep { get; set; }

    }
}
