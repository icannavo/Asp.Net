using Portal.Domain.Interfaces.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Entities
{
    [Serializable]
    public class TipoProduto : ICamposPadroes
    {
        public int TipoProdutoId { get; set; }
        public string Chave { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public long UsuarioCadastro { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public long? UsuarioUltimaAlteracao { get; set; }
               
        
        public int TenantId { get; set; }
        public bool Deletado { get; set; }
        public DateTime? DataDeletado { get; set; }
        public long? UsuarioDelete { get; set; }

        public void Validate()
        {
            
        }
    }
}
