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
    public class ProdutoRepository: BaseRepository, IRepository<Produto>
    {
        public IQueryable<Produto> Obter()
        {
            throw new NotImplementedException();
        }

        public Produto Obter(int id)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Produto instancia)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Produto instancia)
        {
            throw new NotImplementedException();
        }
    }
}
