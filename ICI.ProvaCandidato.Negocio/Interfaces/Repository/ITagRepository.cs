using ICI.ProvaCandidato.Negocio.Interfaces.Global;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Repository
{
    public interface ITagRepository : IRepository<Tag>
    {
        Task<List<Tag>> GetAllAsync();
        Task<IEnumerable<Tag>> GetByIdAsync(int id);
        Task<Tag> Add(Tag tag);
        Task Delete(int id);
        Task Update(Tag tag);
        Task<IEnumerable<Tag>> AnyAsync(int tagId);
    }
}
