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
    public class UsuarioRepository: BaseRepository, IRepository<Usuario>
    {
        public IQueryable<Usuario> Obter()
        {
            throw new NotImplementedException();
        }

        public Usuario Obter(int id)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Usuario instancia)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Usuario instancia)
        {
            throw new NotImplementedException();
        }
    }
}
