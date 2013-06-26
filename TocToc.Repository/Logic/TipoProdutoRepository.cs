using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TocToc.ModelData.Logic;
using System.Data;
using System.Data.Entity;

namespace TocToc.Repository.Logic
{
    public class TipoProdutoRepository : BaseRepository, IRepository<TipoProduto>
    {
        IQueryable<TipoProduto> IRepository<TipoProduto>.Obter()
        {
            throw new NotImplementedException();
        }

        TipoProduto IRepository<TipoProduto>.Obter(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoProduto>.Alterar(TipoProduto instancia)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoProduto>.Excluir(TipoProduto instancia)
        {
            throw new NotImplementedException();
        }
    }
}
