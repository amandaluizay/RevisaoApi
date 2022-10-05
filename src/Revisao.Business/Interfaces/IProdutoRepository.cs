using Revisao.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterPorProdutoCategoria(Guid categoriaId);
        Task<IEnumerable<Produto>> ObterProdutosCategorias();
        Task<Produto> ObterProdutoCategoria(Guid id);

    }
}
