using Portal.Domain.Entities;
using Portal.Domain.Interfaces.Repository;
using Portal.Domain.Interfaces.Repository.ReadOnly;
using Portal.Domain.Interfaces.Service;
using Portal.Domain.Services.Commom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Services
{
    public class TipoProdutoService : Service<TipoProduto>, ITipoProdutoService
    {
        private readonly ITipoProdutoRepository _repository;

        public TipoProdutoService(ITipoProdutoRepository repository, ITipoProdutoReadOnlyRepository readOnlyRepository)
            : base(repository, readOnlyRepository)
        {
            _repository = repository;
        }

        public override void Add(TipoProduto obj)
        {
            obj.Validate();
            base.Add(obj);
        }

        public override void Update(TipoProduto obj)
        {
            obj.Validate();
            base.Update(obj);
        }

        public TipoProduto GetToSave(int id)
        {
            return _repository.GetToSave(id);
        }

        public TipoProduto GetByChaveToSave(string chave)
        {
            return _repository.GetByChaveToSave(chave);
        }

        public TipoProduto GetByCodigoToSave(string codigo)
        {
            return _repository.GetByCodigoToSave(codigo);
        }

        public TipoProduto GetByChaveToSaveAsNoTraking(string chave)
        {
            return _repository.GetByChaveToSaveAsNoTraking(chave);
        }

        public TipoProduto GetByCodigoToSaveAsNoTraking(string codigo)
        {
            return _repository.GetByCodigoToSaveAsNoTraking(codigo);
        }
    }
}
