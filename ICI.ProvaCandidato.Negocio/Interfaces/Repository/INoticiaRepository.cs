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
    public interface INoticiaRepository : IRepository<Noticiia>
    {
        Task<List<Noticiia>> GetAllAsync();
        Task<IEnumerable<Noticiia>> GetByIdAsync(int id);
        Task<Noticiia> AddAsync(Noticiia noticia);
        Task<IEnumerable<Noticiia>> GetById(int id);
        Task<IEnumerable<Noticiia>> AnyAsync(int noticiaId);
    }
}
