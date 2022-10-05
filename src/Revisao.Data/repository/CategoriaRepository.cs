using Microsoft.EntityFrameworkCore;
using Revisao.Business.Interfaces;
using Revisao.Business.Models;
using Revisao.Data.context.RevisaoData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(MeuDbContext context) : base(context)
        {
        }

        public async Task<Categoria> ObterCategoriaProduto(Guid id)
        {
            return await Db.Categorias.AsNoTracking()
                .Include(c => c.Produtos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
