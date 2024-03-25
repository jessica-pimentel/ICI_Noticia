using ICI.ProvaCandidato.Negocio.Interfaces.Global;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class NoticiaTagService : INoticiaTagService
    {
        private readonly INoticiaTagRepository _tagRepository;
        public NoticiaTagService(INoticiaTagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<IEnumerable<NoticiaTag>> GetNoticiaTagsAsync(int noticiaId)
        {
            return await _tagRepository.GetByIdAsync(noticiaId);
        }

        public async Task AddTagToNoticiaAsync(int noticiaId, int tagId)
        {
            var noticiaTag = new NoticiaTag { NoticiaId = noticiaId, TagId = tagId };
            await _tagRepository.Add(noticiaTag);
        }

        public async Task RemoveTagFromNoticiaAsync(int noticiaId, int tagId)
        {
            var noticiaTag = await _tagRepository.FirstOrDefaultAsync(nt => nt.Id == noticiaId && nt.Id == tagId);
            if (noticiaTag != null)
            {
                await _tagRepository.Delete(noticiaTag.Id);
            }
        }

        public async Task<bool> AnyAsync(Func<NoticiaTag, bool> predicate)
        {
            return await _tagRepository.AnyAsync(predicate);
        }
    }
}
