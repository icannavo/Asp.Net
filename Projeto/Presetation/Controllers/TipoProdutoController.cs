using Portal.Web.Base.Helpers;
using Portal.Web.Base.TelaDinamica.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Web.ViewModel.TipoProduto
{
    public class TipoProdutoViewModel
    {
        public TipoProdutoViewModel()
        {
            Ativo = true;
        }

        [TabStart("DadosCadastrais")]
        [Label("ID")]
        [PrimaryKey]
        public int TipoProdutoId { get; set; }

        [Break]
        [Required]
        public string Chave { get; set; }

        [Break]
        [Required]
        public string Codigo { get; set; }

        [Break]
        [Required]
        public string Descricao { get; set; }

        [TabEnd("DadosCadastrais")]
        [Break]
        public bool Ativo { get; set; }

    }
}