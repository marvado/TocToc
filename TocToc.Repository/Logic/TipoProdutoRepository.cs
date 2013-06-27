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
        public IQueryable<TipoProduto> Obter()
        {
            return this.contexto.TipoProdutos.AsQueryable();
        }

        public bool Repetido(string descricao)
        {
            return this.Obter().Where(
                n => descricao == n.Descricao).ToList().Count > 0;
        }

        public TipoProduto Obter(int id)
        {
            throw new NotImplementedException();
        }

        public void Alterar(TipoProduto instancia)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TipoProduto instancia)
        {
            throw new NotImplementedException();
        }

        public void Incluir(TipoProduto instancia)
        {
            this.contexto.TipoProdutos.Add(instancia);
            this.contexto.SaveChanges();
        }
    }
}
