using ICI.ProvaCandidato.Negocio.Interfaces.Global;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Repository
{
    public interface INoticiaTagRepository : IRepository<NoticiaTag>
    {
        Task<List<NoticiaTag>> GetAllAsync();
        Task<IEnumerable<NoticiaTag>> GetByIdAsync(int id);
        Task<NoticiaTag> FirstOrDefaultAsync(Func<NoticiaTag, bool> predicate);
        Task<bool> AnyAsync(Func<NoticiaTag, bool> predicate);

    }
}
