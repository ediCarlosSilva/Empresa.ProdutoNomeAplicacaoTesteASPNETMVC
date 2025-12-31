using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empresa.ProdutoNomeAplicacaoTesteASPNETMVC.Web.Models
{
    public class Frase
    {
        [Required(ErrorMessage = "A Frase deve ser preenchida")]
        [DisplayName("Descrição da Frase: ")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A categoria deve ser preenchida")]
        [DisplayName("Categoria da Frase: ")]
        public string Categoria { get; set; }
        [DisplayName("Likes da Frase: ")]
        public int Likes { get; set; }
    }
}