//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TocToc.ModelData.Logic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Vendas = new HashSet<Venda>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
