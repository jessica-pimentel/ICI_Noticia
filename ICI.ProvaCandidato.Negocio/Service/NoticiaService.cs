using ICI.ProvaCandidato.Negocio.Interfaces.Global;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public async Task<List<Noticiia>> GetAllNoticiasAsync()
        {
            return await _noticiaRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Noticiia>> GetNoticiaByIdAsync(int id)
        {
            return await _noticiaRepository.GetById(id);
        }

        public async Task CreateNoticiaAsync(Noticiia noticia)
        {
            await _noticiaRepository.Add(noticia);
           
        }

        public async Task UpdateNoticiaAsync(Noticiia noticia)
        {
          
            await _noticiaRepository.Update(noticia);
        }

        public async Task DeleteNoticiaAsync(int id)
        {
            await _noticiaRepository.Delete(id);
        }

        public async Task<Noticiia> AddNoticiaAsync(Noticiia noticia)
        {
            await _noticiaRepository.AddAsync(noticia);
            return noticia;
        }

        public async Task<IEnumerable<Noticiia>> IsNoticiaLinkedToNew(int noticiaId)
        {
            return await _noticiaRepository.AnyAsync(noticiaId);
        }
    }
}
