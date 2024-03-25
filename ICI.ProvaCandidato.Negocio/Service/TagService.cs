using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Service
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _repository;
        private readonly INoticiaTagService _noticiaTagService;

        public TagService(ITagRepository repository, INoticiaTagService noticiaTagService)
        {
            _repository = repository;
            _noticiaTagService = noticiaTagService;
        }

        public async Task<List<Tag>> GetAllTagsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Tag>> GetTagByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Tag> AddTagAsync(Tag tag)
        {
            return await _repository.Add(tag);
        }

        public async Task UpdateTagAsync(Tag tag)
        {
            await _repository.Update(tag);
        }

        public async Task DeleteTagAsync(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<IEnumerable<Tag>> IsTagLinkedToNew(int tagId)
        {
            return await _repository.AnyAsync(tagId);
        }
    }
}
