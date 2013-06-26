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
    public class VendaRepository : BaseRepository, IRepository<TipoProduto>
    {
        public IQueryable<Venda> Obter()
        {
            throw new NotImplementedException();
        }

        public Venda Obter(int id)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Venda instancia)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Venda instancia)
        {
            throw new NotImplementedException();
        }

        IQueryable<TipoProduto> IRepository<TipoProduto>.Obter()
        {
            throw new NotImplementedException();
        }

        TipoProduto IRepository<TipoProduto>.Obter(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(TipoProduto instancia)
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
    }
}
