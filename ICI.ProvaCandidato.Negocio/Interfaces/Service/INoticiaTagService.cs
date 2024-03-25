using ICI.ProvaCandidato.Negocio.Models.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Service
{
    public interface INoticiaTagService
    {
        Task<IEnumerable<NoticiaTag>> GetNoticiaTagsAsync(int noticiaId);
        Task AddTagToNoticiaAsync(int noticiaId, int tagId);
        Task RemoveTagFromNoticiaAsync(int noticiaId, int tagId);
        Task<bool> AnyAsync(Func<NoticiaTag, bool> predicate);

    }
}
