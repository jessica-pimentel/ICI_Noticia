using ICI.ProvaCandidato.Negocio.Models.Noticias;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Service
{
    public interface INoticiaService
    {
        Task<List<Noticiia>> GetAllNoticiasAsync();
        Task<IEnumerable<Noticiia>> GetNoticiaByIdAsync(int id);
        Task CreateNoticiaAsync(Noticiia noticia);
        Task UpdateNoticiaAsync(Noticiia noticia);
        Task DeleteNoticiaAsync(int id);
        Task<Noticiia> AddNoticiaAsync(Noticiia noticia);
        Task<IEnumerable<Noticiia>> IsNoticiaLinkedToNew(int id);

    }
}
