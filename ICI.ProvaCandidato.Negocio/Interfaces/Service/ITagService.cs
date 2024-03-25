using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Service
{
    public interface ITagService
    {
        Task<List<Tag>> GetAllTagsAsync();
        Task<IEnumerable<Tag>> GetTagByIdAsync(int id);
        Task<Tag> AddTagAsync(Tag tag);
        Task UpdateTagAsync(Tag tag);
        Task DeleteTagAsync(int id);
        Task<IEnumerable<Tag>> IsTagLinkedToNew(int id);
    }
}
