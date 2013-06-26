using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TocToc.ModelData.Logic;
namespace TocToc.Repository.Logic
{
    public class BaseRepository
    {
        public TocTocEntities contexto;

        public BaseRepository()
        {
            contexto = new TocTocEntities();
        }
    }

    public interface IRepository<T>
    {
        IQueryable<T> Obter();
        T Obter(int id);
        void Incluir(T instancia);
        void Alterar(T instancia);
        void Excluir(T instancia);
    }
}
